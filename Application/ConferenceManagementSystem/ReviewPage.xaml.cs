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
    /// Interaction logic for ReviewPage.xaml
    /// </summary>
    public partial class ReviewPage : Page
    {

        CMSController controller;
        User user;
        public List<Paper> papers { get; set; }

        public ReviewPage(CMSController con, User u)
        {
            this.controller = con;
            this.user = u;
            InitializeComponent();
            DataContext = this;
            loadPapers();
        }

        private void loadPapers()
        {
            papers = controller.getPapers();
            papersListView.ItemsSource = papers;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (papersListView.SelectedItems.Count > 0)
            {
                Paper paper = (Paper)papersListView.SelectedItems[0];
                PDFViewer viewer = new PDFViewer(paper.ContentLoc);
                viewer.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a paper!");
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (papersListView.SelectedItems.Count > 0)
            {
                Paper paper = (Paper)papersListView.SelectedItems[0];
                PDFViewer viewer = new PDFViewer(paper.AbstractLoc);
                viewer.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a paper!");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (user.RoleID == 4)
            {
                if (papersListView.SelectedItems.Count > 1 || papersListView.SelectedItems.Count == 0)
                {
                    MessageBox.Show("You must select only one session");
                    return;
                }
                Paper paper = (Paper)papersListView.SelectedItems[0];

                if (qualifComboBox.SelectedValue == null)
                {
                    MessageBox.Show("You must select a qualifier");
                    return;
                }
                else
                {
                    string qual = qualifComboBox.SelectedValue.ToString();
                }

                if (string.IsNullOrWhiteSpace(commentBox.Text))
                {
                    MessageBox.Show("Please write specifications");
                    return;
                }



            }
        }
    }
}
