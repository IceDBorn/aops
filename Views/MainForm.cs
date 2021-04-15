﻿using System;
using System.Drawing;
using System.Windows.Forms;
using filmhub.Properties;

namespace filmhub.Views
{
    public partial class MainForm : Form
    {

        #region Constructor

        public MainForm()
        {
            InitializeComponent();
            InitializeColors();
            UserControlSelector(new WelcomeUserControl(), false);
        }

        #endregion

        #region Methods

        private void InitializeColors()
        {
            navBar.BackColor = Program.Colors.NavBarBackgroundColor;
            searchBar.BackColor = Program.Colors.FieldColor;
            searchBar.ForeColor = Program.Colors.FieldDarkTextColor;
            mainPage.BackColor = Program.Colors.BackgroundColor;
            favoritesLabel.BackColor = Program.Colors.PopOutBackgroundColor;
            watchListLabel.BackColor = Program.Colors.PopOutBackgroundColor;
            historyLabel.BackColor = Program.Colors.PopOutBackgroundColor;
            settingsLabel.BackColor = Program.Colors.PopOutBackgroundColor;
            logoutLabel.BackColor = Program.Colors.PopOutBackgroundColor;
            dropDownPanel.BackColor = Program.Colors.PopOutBackgroundColor;
        }

        public void UserControlSelector(Control userControl, bool flag)
        {
            mainPage.Controls.Clear();
            mainPage.Controls.Add(userControl);
            iconsPanel.Visible = flag;
        }
        
        public void HideDropDown()
        {
            dropDownPanel.Visible = false;
            accountButton.Image = Resources.account;
            GC.Collect();
        }

        #endregion

        #region Events
        
        private void searchBar_Enter(object sender, EventArgs e)
        {
            if (searchBar.Text.Equals(@" Enter your search"))
            {
                searchBar.Text = "";
            }
        }

        private void searchBar_Leave(object sender, EventArgs e)
        {
            if (searchBar.Text.Equals(""))
            {
                searchBar.Text = @" Enter your search";
            }
        }

        private void accountButton_Click(object sender, EventArgs e)
        {
            dropDownPanel.Visible = !dropDownPanel.Visible;
        }

        private void favoritesLabel_Click(object sender, EventArgs e)
        {
            Program.MainForm.UserControlSelector(new FavoritesUserControl(), true);
            dropDownPanel.Visible = false;
        }

        private void favoritesLabel_MouseHover(object sender, EventArgs e)
        {
            favoritesLabel.ForeColor = Program.Colors.AccentColor;
        }

        private void favoritesLabel_MouseLeave(object sender, EventArgs e)
        {
            favoritesLabel.ForeColor = Color.White;
        }

        private void watchListLabel_Click(object sender, EventArgs e)
        {
            Program.MainForm.UserControlSelector(new WatchlistUserControl(), true);
            dropDownPanel.Visible = false;
        }

        private void watchListLabel_MouseHover(object sender, EventArgs e)
        {
            watchListLabel.ForeColor = Program.Colors.AccentColor;
        }

        private void watchListLabel_MouseLeave(object sender, EventArgs e)
        {
            watchListLabel.ForeColor = Color.White;
        }

        private void historyLabel_Click(object sender, EventArgs e)
        {
            Program.MainForm.UserControlSelector(new HistoryUserControl(), true);
            dropDownPanel.Visible = false;
        }

        private void historyLabel_MouseHover(object sender, EventArgs e)
        {
            historyLabel.ForeColor = Program.Colors.AccentColor;
        }

        private void historyLabel_MouseLeave(object sender, EventArgs e)
        {
            historyLabel.ForeColor = Color.White;
        }

        private void settingsLabel_Click(object sender, EventArgs e)
        {
            Program.MainForm.UserControlSelector(new SettingsUserControl(), true);
            dropDownPanel.Visible = false;
        }

        private void settingsLabel_MouseHover(object sender, EventArgs e)
        {
            settingsLabel.ForeColor = Program.Colors.AccentColor;
        }

        private void settingsLabel_MouseLeave(object sender, EventArgs e)
        {
            settingsLabel.ForeColor = Color.White;
        }

        private void logoutLabel_Click(object sender, EventArgs e)
        {
            Program.MainForm.UserControlSelector(new WelcomeUserControl(), false);
            dropDownPanel.Visible = false;
        }

        private void logoutLabel_MouseHover(object sender, EventArgs e)
        {
            logoutLabel.ForeColor = Program.Colors.AccentColor;
        }

        private void logoutLabel_MouseLeave(object sender, EventArgs e)
        {
            logoutLabel.ForeColor = Color.White;
        }
        
        private void homeButton_Click(object sender, EventArgs e)
        {
            UserControlSelector(new MainPageUserControl(), true);
        }

        private void homeButton_MouseHover(object sender, EventArgs e)
        {
            homeButton.Image = Resources.home_hover;
            GC.Collect();
        }

        private void homeButton_MouseLeave(object sender, EventArgs e)
        {
            homeButton.Image = Resources.home;
            GC.Collect();
        }

        private void searchButton_MouseHover(object sender, EventArgs e)
        {
            searchButton.Image = Resources.search_hover;
            GC.Collect();
        }

        private void searchButton_MouseLeave(object sender, EventArgs e)
        {
            searchButton.Image = Resources.search;
            GC.Collect();
        }

        private void accountButton_MouseHover(object sender, EventArgs e)
        {
            accountButton.Image = Resources.account_hover;
            GC.Collect();
        }

        private void accountButton_MouseLeave(object sender, EventArgs e)
        {
            if (dropDownPanel.Visible) return;
            accountButton.Image = Resources.account;
            GC.Collect();
        }
        
        private void iconsPanel_Click(object sender, EventArgs e)
        {
            HideDropDown();
        }
        
        #endregion
    }
}