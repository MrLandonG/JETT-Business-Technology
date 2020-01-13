using System;
using System.Drawing;
using System.Windows.Forms;

namespace JETT_Business_Technology
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The user is rediriected to the JETT BT website by clicking linkLabel_website
        private void linkLabel_website_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                openLink(linkLabel_website, "https://www.jettbt.com/");
            }

            catch (Exception)
            {
                MessageBox.Show("Unable to open link.");
            }
        }

        // The user is rediriected to the Client Portal Login by clicking linkLabel_ticket
        private void linkLabel_ticket_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                openLink(linkLabel_ticket, "https://ww3.autotask.net/ClientPortal/Login.aspx?ci=301020");
            }

            catch (Exception)
            {
                MessageBox.Show("Unable to open link.");
            }
        }

        // The user is rediriected to the google maps address of JETT BT by clicking linkLabel_location
        private void linklabel_location_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                openLink(linkLabel_ticket, "http://maps.google.com/maps?q= JETT Business Technology");
            }

            catch (Exception)
            {
                MessageBox.Show("Unable to open link.");
            }
        }

        // Sets the clicked label as visitied and opens the link
        private void openLink(LinkLabel linkLabel, String link)
        {
            linkLabel.LinkVisited = true;
            System.Diagnostics.Process.Start(link);
        }

        // Opens the default email client with the recipient predefined
        private void linkLabel_email_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            String recipient = "helpdesk@jettbt.com";
            System.Diagnostics.Process.Start("mailto:" + recipient);
        }

        // Panel mouseEnter and mouseLeave events
        private void panel_phone_MouseEnter(object sender, EventArgs e)
        {
            Image image = Properties.Resources.phone_reverse;
            swapEnter(panel_phone, label_number, pictureBox_phone, image);
        }

        private void panel_phone_MouseLeave(object sender, EventArgs e)
        {
            Image image = Properties.Resources.phone;
            swapLeave(panel_phone, label_number, pictureBox_phone, image);
        }

        private void panel_ticket_MouseEnter(object sender, EventArgs e)
        {
            Image image = Properties.Resources.ticket_reverse;
            swapEnter(panel_ticket, linkLabel_ticket, pictureBox_ticket, image);
        }

        private void panel_ticket_MouseLeave(object sender, EventArgs e)
        {
            Image image = Properties.Resources.ticket;
            swapLeave(panel_ticket, linkLabel_ticket, pictureBox_ticket, image);
        }

        private void panel_email_MouseEnter(object sender, EventArgs e)
        {
            Image image = Properties.Resources.email_reverse;
            swapEnter(panel_email, linkLabel_email, pictureBox_email, image);
        }

        private void panel_email_MouseLeave(object sender, EventArgs e)
        {
            Image image = Properties.Resources.email;
            swapLeave(panel_email, linkLabel_email, pictureBox_email, image);
        }

        private void panel_website_MouseEnter(object sender, EventArgs e)
        {
            Image image = Properties.Resources.website_reverse;
            swapEnter(panel_website, linkLabel_website, pictureBox_website, image);
        }

        private void panel_website_MouseLeave(object sender, EventArgs e)
        {
            Image image = Properties.Resources.website;
            swapLeave(panel_website, linkLabel_website, pictureBox_website, image);
        }

        private void panel_location_MouseEnter(object sender, EventArgs e)
        {
            Image image = Properties.Resources.location_reverse;
            swapEnter(panel_location, linklabel_location, pictureBox_location, image);
        }

        private void panel_location_MouseLeave(object sender, EventArgs e)
        {
            Image image = Properties.Resources.location;
            swapLeave(panel_location, linklabel_location, pictureBox_location, image);
        }

        // Label and LinkLabel mouseEnter and mouseLeave events
        private void label_number_MouseEnter(object sender, EventArgs e)
        {
            Image image = Properties.Resources.phone_reverse;
            swapEnter(panel_phone, label_number, pictureBox_phone, image);
        }

        private void label_number_MouseLeave(object sender, EventArgs e)
        {
            Image image = Properties.Resources.phone;
            swapLeave(panel_phone, label_number, pictureBox_phone, image);
        }

        private void linkLabel_ticket_MouseEnter(object sender, EventArgs e)
        {
            Image image = Properties.Resources.ticket_reverse;
            swapEnter(panel_ticket, linkLabel_ticket, pictureBox_ticket, image);
        }

        private void linkLabel_ticket_MouseLeave(object sender, EventArgs e)
        {
            Image image = Properties.Resources.ticket;
            swapLeave(panel_ticket, linkLabel_ticket, pictureBox_ticket, image);
        }

        private void linkLabel_email_MouseEnter(object sender, EventArgs e)
        {
            Image image = Properties.Resources.email_reverse;
            swapEnter(panel_email, linkLabel_email, pictureBox_email, image);
        }

        private void linkLabel_email_MouseLeave(object sender, EventArgs e)
        {
            Image image = Properties.Resources.email;
            swapLeave(panel_email, linkLabel_email, pictureBox_email, image);
        }

        private void linkLabel_website_MouseEnter(object sender, EventArgs e)
        {
            Image image = Properties.Resources.website_reverse;
            swapEnter(panel_website, linkLabel_website, pictureBox_website, image);
        }

        private void linkLabel_website_MouseLeave(object sender, EventArgs e)
        {
            Image image = Properties.Resources.website;
            swapLeave(panel_website, linkLabel_website, pictureBox_website, image);
        }

        private void linklabel_location_MouseEnter(object sender, EventArgs e)
        {
            Image image = Properties.Resources.location_reverse;
            swapEnter(panel_location, linklabel_location, pictureBox_location, image);
        }

        private void linklabel_location_MouseLeave(object sender, EventArgs e)
        {
            Image image = Properties.Resources.location;
            swapEnter(panel_location, linklabel_location, pictureBox_location, image);
        }

        // PictureBox mouseEnter and mouseLeave events
        private void pictureBox_phone_MouseEnter(object sender, EventArgs e)
        {
            Image image = Properties.Resources.phone_reverse;
            swapEnter(panel_phone, label_number, pictureBox_phone, image);
        }

        private void pictureBox_phone_MouseLeave(object sender, EventArgs e)
        {
            Image image = Properties.Resources.phone;
            swapLeave(panel_phone, label_number, pictureBox_phone, image);
        }

        private void pictureBox_ticket_MouseEnter(object sender, EventArgs e)
        {
            Image image = Properties.Resources.ticket_reverse;
            swapEnter(panel_ticket, linkLabel_ticket, pictureBox_ticket, image);
        }

        private void pictureBox_ticket_MouseLeave(object sender, EventArgs e)
        {
            Image image = Properties.Resources.ticket;
            swapLeave(panel_ticket, linkLabel_ticket, pictureBox_ticket, image);
        }

        private void pictureBox_email_MouseEnter(object sender, EventArgs e)
        {
            Image image = Properties.Resources.email_reverse;
            swapEnter(panel_email, linkLabel_email, pictureBox_email, image);
        }

        private void pictureBox_email_MouseLeave(object sender, EventArgs e)
        {
            Image image = Properties.Resources.email;
            swapLeave(panel_email, linkLabel_email, pictureBox_email, image);
        }

        private void pictureBox_website_MouseEnter(object sender, EventArgs e)
        {
            Image image = Properties.Resources.website_reverse;
            swapEnter(panel_website, linkLabel_website, pictureBox_website, image);
        }

        private void pictureBox_website_MouseLeave(object sender, EventArgs e)
        {
            Image image = Properties.Resources.website;
            swapLeave(panel_website, linkLabel_website, pictureBox_website, image);
        }

        private void pictureBox_location_MouseEnter(object sender, EventArgs e)
        {
            Image image = Properties.Resources.location_reverse;
            swapEnter(panel_location, linklabel_location, pictureBox_location, image);
        }

        private void pictureBox_location_MouseLeave(object sender, EventArgs e)
        {
            Image image = Properties.Resources.location;
            swapLeave(panel_location, linklabel_location, pictureBox_location, image);
        }

        // Swaps colors and picture when users mouse hovers over control
        private void swapEnter(Panel panel, Label label, PictureBox picture, Image image)
        {
            panel.BackColor = Color.FromArgb(60, 153, 193);
            label.ForeColor = Color.White;
            picture.Image = image;
            picture.BackColor = Color.Transparent;
            picture.Refresh();
        }

        // Overridden swapEnter method for linkLabel parameter
        private void swapEnter(Panel panel, LinkLabel linkLabel, PictureBox picture, Image image)
        {
            panel.BackColor = Color.FromArgb(60, 153, 193);
            linkLabel.LinkColor = Color.White;
            picture.Image = image;
            picture.BackColor = Color.Transparent;
            picture.Refresh();
        }

        // Swaps colors and picture when users mouse leaves control
        private void swapLeave(Panel panel, Label label, PictureBox picture, Image image)
        {
            panel.BackColor = Color.White;
            label.ForeColor = Color.Black;
            picture.Image = image;
            picture.Refresh();
        }

        // Overridden swapLeave method for linkLabel parameter
        private void swapLeave(Panel panel, LinkLabel linkLabel, PictureBox picture, Image image)
        {
            panel.BackColor = Color.White;
            linkLabel.LinkColor = Color.FromArgb(60, 153, 193);
            picture.Image = image;
            picture.Refresh();
        }
    }
}
