using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CatsMVC.Model;
using CatsMVC.Controller;

namespace CatsMVC.View
{
    public partial class CatsView : Form
    {
        List<Cat> cats;
        CatsController catsController = new CatsController();

        public CatsView()
        {
            InitializeComponent();
        }

        

        private void insertBtn_Click(object sender, EventArgs e)
        {
            Cat c = new Cat();
            c.Name = nameInput.Text;
            c.Age = int.Parse(ageInput.Text);
            c.Id = int.Parse(idInput.Text);

            catsController.Insert(c);
         
            UpdateData();
        }

        private void deleteLastBtn_Click(object sender, EventArgs e)
        {
            catsController.DeleteLast();

            UpdateData();
        }

        private void deleteIdBtn_Click(object sender, EventArgs e)
        {
            catsController.DeleteById(int.Parse(idInput.Text));

            UpdateData();
        }

        private void updateIdBtn_Click(object sender, EventArgs e)
        {
            string name = nameInput.Text;
            int age = int.Parse(ageInput.Text);
            int id = int.Parse(idInput.Text);

            catsController.UpdateById(id, name, age);

            UpdateData();
        }

        private void UpdateData()
        {
            cats = new List<Cat>(catsController.GetAll());
            dataGridView1.DataSource = cats;
        }
    }
}
