﻿using ConferenceManagementSystem.Controller;
using ConferenceManagementSystem.Domain;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ConferenceManagementSystem
{
    /// <summary>
    /// Interaction logic for ConfManagementPage.xaml
    /// </summary>
    public partial class ConfManagementPage : Page
    {
        private CMSController controller;
        private User user;
        public List<Conference> conferences { get; set; }

        public ConfManagementPage(CMSController controller, User user)
        {
            this.user = user;
            this.controller = controller;
            InitializeComponent();
            conferences = this.controller.getConferences();

        }

    }
}
