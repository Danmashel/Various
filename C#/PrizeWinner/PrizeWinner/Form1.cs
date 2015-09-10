using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrizeWinner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Declare globals class to hold global variables
        public static class Globals 
        {
            public static List<participant> participants = new List<participant>(); //Contains a list of all the participant objects
            public static List<string> tickets = new List<string>(); //Contains the list of 'tickets' to be randomly selected from
        }

        //participant object to contain name and ticket totals for individuals
        public class participant
        {
            public string name { get; set; } //public name
            public int ticketTotal { get; set; } //public ticket total
        }

        //Runs when form loads
        public void Form1_Load(object sender, EventArgs e)
        {
            string[] lines = System.IO.File.ReadAllLines("defaultMembers.txt"); //Reads the default members from the defaultMemeber.txt file and stores in an array
            foreach (string line in lines) //Iterates over each line in the text files
            {
                Globals.participants.Add(new participant { name = line, ticketTotal = 0 }); //Adds each line as an object, to the global participants object list from above.
                participantsList.Items.Add(line); //Adds them to the comboBox
                refreshTotals(); //Refreshes the names and totals on the right-hand side
            }
        }

        //Picks a random winner
        private void pickButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random(); //Creates new Random object
            int randomNumber = rnd.Next(0, Globals.tickets.Count()); //Generates random number between 0 and the length of the tickets list
            if (Globals.tickets.Count() > 0) //Only fires if there are actually tickets in the list
            {
                string winnerName = Globals.tickets[randomNumber]; //Sets the randomly selected winner's name by plugging in the random number as array index value
                MessageBox.Show(winnerName + " is the winner!"); //Shows who the winner is
                Globals.tickets.RemoveAll(item => item == winnerName); //Removes all entries in tickets where the name matches the winner (so they cant win again)
            }
            else
            {
                MessageBox.Show("There are no more eligible people to win"); //If nobody is in the ticket list that can win
            }
            
        }

        //Refresh right-hand side with name and totals
        public void refreshTotals(){ 
            ticketsList.Items.Clear(); //Clears the whole list, which will be refreshed.
            foreach (participant part in Globals.participants)//Iterates over each participant object in the global participants list with the temporary value 'part'
            { 
                if (part.name == participantsList.Text){ //checks to see if the name it's on matches the selected participant
                    part.ticketTotal = part.ticketTotal + 1; //if it matches, it increases the ticket total by 1                 
                }
                ticketsList.Items.Add(part.name + "(" + part.ticketTotal.ToString() + ")"); //Creates the actual string to be placed in the right-hand size
            }
        }

        //Adds a ticket for selected participant
        private void addTicketButton_Click(object sender, EventArgs e)
        {
            if (participantsList.SelectedIndex >= 0) //Checks to see if you actually selected a participant
            {
                refreshTotals(); //Calls the refresh totals method
                Globals.tickets.Add(participantsList.Text); //Adds the name to the global tickets list
            }
        }

        //Add a new participant to existing. Does not update default text
        private void addButton_Click(object sender, EventArgs e)
        {
            if (newName.Text != null) //Checks to make sure you've actually entered something
            {
                Globals.participants.Add(new participant { name = newName.Text, ticketTotal = 0 }); //adds object to global participants list
                participantsList.Items.Add(newName.Text); //adds name to drop-down comboBox
                MessageBox.Show("You have successfully added " + newName.Text + " to the list"); //Tells you it added it
                refreshTotals(); //Refreshes the right-hand side with new information
            }
            else
            {
                MessageBox.Show("You must enter a name"); //You are an idiot
            }
        }

        //Remove a participant
        private void removeButton_Click(object sender, EventArgs e)
        {
            if (participantsList.SelectedIndex >= 0) //Makes sure you've selected someone
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove " + participantsList.Text + "?", "Remove Participant", MessageBoxButtons.YesNo); //prompts to make sure you really want to remove them.
                if (dialogResult == DialogResult.Yes) //If your response was 'yes' then it runs below
                {
                    Globals.participants.RemoveAll(x => x.name == participantsList.Text); //Removes all existing tickets from global tickets list
                    Globals.tickets.RemoveAll(x => x == participantsList.Text); //Removes all objects from participants object list where the name equals the selected name
                    participantsList.Items.Remove(participantsList.Text); //Removes the name from the drop-down comboBox
                    refreshTotals(); //Refreshes the right-hand side with new information
                }
            }
        }        
    }
}
