﻿using ConferenceManagementSystem.Controller;
using ConferenceManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ConferenceManagementSystem
{
    /// <summary>
    /// Interaction logic for UserMainWindow.xaml
    /// </summary>
    public partial class UserMainWindow : Window
    {
        private CMSController controller;
        private User user;

        public UserMainWindow(CMSController controller, User user)
        {
            this.user = user;
            this.controller = controller;
            InitializeComponent();
            fullNameLabel.Content = user.LastName.ToUpper() + " " + user.FirstName.ToUpper() + ", " + user.RoleID.ToString();
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ProfileItem_Selected(object sender, RoutedEventArgs e)
        {
            contentFrame.Content = new ProfilePage(controller,user);
        }

        private void ConferencesItem_Selected(object sender, RoutedEventArgs e)
        {
            contentFrame.Content = new ConferencesPage(controller, user);
        }

        private void MyConferencesItem_Selected(object sender, RoutedEventArgs e)
        {
            contentFrame.Content = new MyConferencesPage(controller, user);
        }

        private void PapersItem_Selected(object sender, RoutedEventArgs e)
        {
            if (user.RoleID == 5)
                MessageBox.Show("You don't have the right to acces this page");
            else
            {

            }
        }

        private void ReviewsItem_Selected(object sender, RoutedEventArgs e)
        {
            if (user.RoleID == 5 || user.RoleID == 1)
                MessageBox.Show("You don't have the right to acces this page");
            else
            {

            }
        }

        private void DeadlineItem_Selected(object sender, RoutedEventArgs e)
        {
            if (user.RoleID == 5)
                MessageBox.Show("You don't have the right to acces this page");
            else
            {

            }
        }
    }
}
