#!/bin/bash

#Author1: Matthew Shelley																																						
#Description: To automate the mounting process for Windows 7 & 8.x drives that need to be fixed. 
#Requirements: Ubuntu or Ubuntu based distro                                                     
#Version: 1.1.0																					


#Create /Desktop/Mount fold if doesn't exist
if [ -d "$HOME/Desktop/Mount" ]; then
	echo "Mount directory exists. Continuing..."
else
	echo "Mount directory doesn't exist, creating in $HOME/Desktop/Mount"
	sudo mkdir $HOME/Desktop/Mount
	sudo chmod 777 $HOME/Desktop/Mount
fi
# Detect DE and disable auto mount
distribType=$(cat /etc/lsb-release | grep DISTRIB_ID | sed 's/DISTRIB_ID=//g')
if [ "$distribType" = "LinuxMint" ]; then
	desktopEnv="cinnamon"
elif [ "$distribType" = "Ubuntu" ]; then
	desktopEnv="gnome"
else 
	desktopEnv=""
fi

if [ "$desktopEnv" != "" ]; then
	gsettings set org.$desktopEnv.desktop.media-handling automount-open false
	gsettings set org.$desktopEnv.desktop.media-handling automount false
	echo "Disabled system auto mount for $distribType"
else 
	echo "Distribution not detected. Not disabling system auto mount."
fi

mountFolder=$HOME/Desktop/Mount
snapshot=$(sudo lsblk | awk '{print $1}')
echo "Waiting for device connection"
getUUID(){
	UUID=$(blkid $1 -s UUID | awk '{ print $2 }' | sed -e 's/"//g' -e 's/UUID=//g')
		if [ "$UUID" = "" ]; then
			UUID=$(uuidgen)
		fi 
	echo $UUID
}
mountDrive(){

		driveSize=$(sudo parted $1 unit MB print | awk '{ print $4 }' | tail -n +7 | sed 's/MB//g')
		if [ "$driveSize" -gt 50000 ]; then
			read -p "Detected "$driveSize"MB NTFS partition at $1. Would you like to mount? (y/n): " driveMount
			if [ "$driveMount" = "y" ]; then
				UUID=$(getUUID $1)
				$(sudo mkdir $mountFolder/$UUID && sudo chmod 777 $mountFolder/$UUID)
				$(sudo ntfsfix $1 2> /dev/null)
				$(sudo mount -t ntfs-3g -o remove_hiberfile $1 $mountFolder/$UUID)
				echo $1 was mounted to $mountFolder/$UUID
				unmountDrive $1
			else
				echo "Waiting for device connection"
			fi
		fi	
}
unmountDrive(){
	read -p "Ready to unmount? (y/n): " dismount
	if [ "$dismount" = "y" ]; then
		read -p "Are you sure? (y/n): " sure
		if [ "$sure" = "y" ]; then
			$(sudo umount $1)
			$(sudo rm -rf $mountFolder/$UUID)
			read -p "Drive unmounted successfully. Do you wish to close the program? (y/n): " close
			if [ "$close" = "y" ]; then
				if [ "$desktopEnv" != "" ]; then
					gsettings set org.$desktopEnv.desktop.media-handling automount-open true
					gsettings set org.$desktopEnv.desktop.media-handling automount true
				fi				
				exit
			else
				echo "Waiting for device connection"
			fi
		else
			unmountDrive $1
		fi
	else
		unmountDrive $1
	fi
}
while true; do
	if [ "$(lsblk | awk '{print $1}')" = "$snapshot" ]; then
		sleep 0.1		
	else
		snapshot=$(lsblk | awk '{print $1}') #update snapshot
		fsType="mbr"
		gptmbr=$(sudo fdisk -l 2> /dev/null | grep /dev/ | awk '{ print $6 }')
		for i in $gptmbr; do
			if [ "$i" = "GPT" ]; then
				gptmbr="GPT"
			elif [ "$i" = "HPFS/NTFS/exFAT" ]; then
				gptmbr="MBR"
			fi
		done
		if [ "$gptmbr" = "GPT" ];then
			rootDrive=$(sudo fdisk -l 2> /dev/null | sed 's/*//g' | awk '{ if($6=="GPT") print $1 ; }' | sed 's/[1-9]//g'| sed '\/dev\/sda/d')
			drives=$(sudo parted $rootDrive print | awk '{ if($5=="ntfs") print "'$rootDrive'" $1 ; }'| sed '\/dev\/sda/d')
			for i in $drives; do
				mountDrive $i
			done			
		elif [ "$gptmbr" = "MBR" ]; then
			fsType="MBR"
			drives=$(sudo fdisk -l 2> /dev/null | sed 's/*//g' | awk '{ if($6=="HPFS/NTFS/exFAT") print $1 ; }' | sed '\/dev\/sda/d')
			for i in $drives; do
				mountDrive $i
			done
		fi
		
	fi
	sleep 1
done


