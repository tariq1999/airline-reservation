namespace airline2
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.flightDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewFlightsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flightDetailsToolStripMenuItem,
            this.customerDetailsToolStripMenuItem,
            this.ticketDetailsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // flightDetailsToolStripMenuItem
            // 
            this.flightDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewFlightsToolStripMenuItem});
            this.flightDetailsToolStripMenuItem.Name = "flightDetailsToolStripMenuItem";
            this.flightDetailsToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.flightDetailsToolStripMenuItem.Text = "Flight Details";
            // 
            // addNewFlightsToolStripMenuItem
            // 
            this.addNewFlightsToolStripMenuItem.Name = "addNewFlightsToolStripMenuItem";
            this.addNewFlightsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addNewFlightsToolStripMenuItem.Text = "Add New Flights";
            this.addNewFlightsToolStripMenuItem.Click += new System.EventHandler(this.addNewFlightsToolStripMenuItem_Click);
            // 
            // customerDetailsToolStripMenuItem
            // 
            this.customerDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewCustomerToolStripMenuItem,
            this.SearchCustomer});
            this.customerDetailsToolStripMenuItem.Name = "customerDetailsToolStripMenuItem";
            this.customerDetailsToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.customerDetailsToolStripMenuItem.Text = "Customer Details";
            // 
            // addNewCustomerToolStripMenuItem
            // 
            this.addNewCustomerToolStripMenuItem.Name = "addNewCustomerToolStripMenuItem";
            this.addNewCustomerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addNewCustomerToolStripMenuItem.Text = "Add New Customer";
            this.addNewCustomerToolStripMenuItem.Click += new System.EventHandler(this.addNewCustomerToolStripMenuItem_Click);
            // 
            // SearchCustomer
            // 
            this.SearchCustomer.Name = "SearchCustomer";
            this.SearchCustomer.Size = new System.Drawing.Size(224, 26);
            this.SearchCustomer.Text = "Search Customer";
            this.SearchCustomer.Click += new System.EventHandler(this.SearchCustomer_Click);
            // 
            // ticketDetailsToolStripMenuItem
            // 
            this.ticketDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookTicketToolStripMenuItem});
            this.ticketDetailsToolStripMenuItem.Name = "ticketDetailsToolStripMenuItem";
            this.ticketDetailsToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.ticketDetailsToolStripMenuItem.Text = "Ticket Details";
            // 
            // bookTicketToolStripMenuItem
            // 
            this.bookTicketToolStripMenuItem.Name = "bookTicketToolStripMenuItem";
            this.bookTicketToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bookTicketToolStripMenuItem.Text = "Book Ticket";
            this.bookTicketToolStripMenuItem.Click += new System.EventHandler(this.bookTicketToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Main";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem flightDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewFlightsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SearchCustomer;
        private System.Windows.Forms.ToolStripMenuItem ticketDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookTicketToolStripMenuItem;
    }
}