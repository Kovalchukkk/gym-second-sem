using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gym;

namespace AdminWindowsForms
{
    public partial class Form1 : Form
    {
        Repository<Visitor> VisitorRepository;
        Repository<Trainer> TrainerRepository;
        Helper helper = new Helper();
        Color HoverButtonColor = Color.BlueViolet;
        Color DefaultButtonColor = Color.DodgerBlue;
        public Form1()
        {
            var factory = FactoryCreator.GetFactory();
            VisitorRepository = factory.GetVisitorRepository();
            TrainerRepository = factory.GetTrainerRepository();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = VisitorRepository.GetAll();
            dataGridView2.DataSource = TrainerRepository.GetAll();
        }

        private void mouseHover(Button button)
        {
            button.BackColor = HoverButtonColor;
        }

        private void mouseLeave(Button button)
        {
            button.BackColor = DefaultButtonColor;
        }

        /* Visitor */
        private void SaveVisitor_Click(object sender, EventArgs e) 
        {
            try
            {
                Visitor temp = new Visitor(tbName.Text, tbCountry.Text, tbMembershipcard.Text, tbBirthday.Text);
                TrainerRepository.SetTrainer(temp, int.Parse(tbTrainersid.Text));
                VisitorRepository.Add(temp);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = VisitorRepository.GetAll();
                MessageBox.Show("Visitor added!!!");
            }
            catch(Exception)
            {
                MessageBox.Show("Some errors were found!");
            }
        }

        private void ViewTheMostPopularTrainer_Click(object sender, EventArgs e) 
        {
            try
            {
                tbThemostpopular.Text = helper.ShowTheMostPopularTrainer();
            }
            catch (Exception)
            {
                MessageBox.Show("Some errors were found!");
            }
        }

        private void ClearTheMostPopularTrainer_Click(object sender, EventArgs e)
        {
            tbThemostpopular.Text = "";
        }

        private void DeleteVisitor_Click(object sender, EventArgs e)
        {
            try
            {
                int delId = int.Parse(tbVisitorsIDDel.Text);
                VisitorRepository.Del(delId);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = VisitorRepository.GetAll();
                MessageBox.Show("Visitor deleted!!!");
            }
            catch (Exception)
            {
                MessageBox.Show("Some errors were found!");
            }
        }

        private void ViewTheMostExperiencedTrainer_Click(object sender, EventArgs e)
        {
            try
            {
                tbThemostexperienced.Text = TrainerRepository.MaxTrainer();
            }
            catch (Exception)
            {
                MessageBox.Show("Some errors were found!");
            }
        }

        private void ClearTheMostExperiencedTrainer_Click(object sender, EventArgs e)
        {
            tbThemostexperienced.Text = "";
        }

        private void ViewVisitorsDiscounts_Click(object sender, EventArgs e)
        {
            try
            {
                int discId = int.Parse(tbVisitorsIDDiscount.Text);
                richTextBoxDiscounts.Text = VisitorRepository.ShowDiscount(discId);
            }
            catch (Exception)
            {
                MessageBox.Show("Some errors were found!");
            }
        }

        private void ClearVisitorsDiscounts_Click(object sender, EventArgs e)
        {
            tbVisitorsIDDiscount.Text = "";
            richTextBoxDiscounts.Text = "";
        }

        private void ClearVisitor_Click(object sender, EventArgs e)
        {
            tbName.Text = "";
            tbCountry.Text = "";
            tbBirthday.Text = "";
            tbMembershipcard.Text = "";
            tbTrainersid.Text = "";
        }

        
        /* Hover */
        private void SaveVisitor_MouseHover(object sender, EventArgs e)
        {
            mouseHover(SaveVisitor);
        }

        private void ViewTheMostPopularTrainer_MouseHover(object sender, EventArgs e)
        {
            mouseHover(ViewTheMostPopularTrainer);
        }

        private void ClearTheMostPopularTrainer_MouseHover(object sender, EventArgs e)
        {
            mouseHover(ClearTheMostPopularTrainer);
        }

        private void DeleteVisitor_MouseHover(object sender, EventArgs e)
        {
            mouseHover(DeleteVisitor);
        }

        private void ViewTheMostExperiencedTrainer_MouseHover(object sender, EventArgs e)
        {
            mouseHover(ViewTheMostExperiencedTrainer);
        }

        private void ClearTheMostExperiencedTrainer_MouseHover(object sender, EventArgs e)
        {
            mouseHover(ClearTheMostExperiencedTrainer);
        }

        private void ViewVisitorsDiscounts_MouseHover(object sender, EventArgs e)
        {
            mouseHover(ViewVisitorsDiscounts);
        }

        private void ClearVisitorsDiscounts_MouseHover(object sender, EventArgs e)
        {
            mouseHover(ClearVisitorsDiscounts);
        }

        private void ClearVisitor_MouseHover(object sender, EventArgs e)
        {
            mouseHover(ClearVisitor);
        }


        /* Leave */
        private void SaveVisitor_MouseLeave(object sender, EventArgs e)
        {
            mouseLeave(SaveVisitor);
        }

        private void ViewTheMostPopularTrainer_MouseLeave(object sender, EventArgs e)
        {
            mouseLeave(ViewTheMostPopularTrainer);
        }

        private void ClearTheMostPopularTrainer_MouseLeave(object sender, EventArgs e)
        {
            mouseLeave(ClearTheMostPopularTrainer);
        }

        private void DeleteVisitor_MouseLeave(object sender, EventArgs e)
        {
            mouseLeave(DeleteVisitor);
        }

        private void ViewTheMostExperiencedTrainer_MouseLeave(object sender, EventArgs e)
        {
            mouseLeave(ViewTheMostExperiencedTrainer);
        }

        private void ClearTheMostExperiencedTrainer_MouseLeave(object sender, EventArgs e)
        {
            mouseLeave(ClearTheMostExperiencedTrainer);
        }

        private void ViewVisitorsDiscounts_MouseLeave(object sender, EventArgs e)
        {
            mouseLeave(ViewVisitorsDiscounts);
        }

        private void ClearVisitorsDiscounts_MouseLeave(object sender, EventArgs e)
        {
            mouseLeave(ClearVisitorsDiscounts);
        }

        private void ClearVisitor_MouseLeave(object sender, EventArgs e)
        {
            mouseLeave(ClearVisitor);
        }


        /* Trainer */
        private void SaveTrainer_Click(object sender, EventArgs e)
        {
            try
            {
                Trainer temp = new Trainer(tbNameTrainer.Text, int.Parse(tbExperienceTrainer.Text));
                TrainerRepository.Add(temp);
                TrainerRepository.SetId();
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = TrainerRepository.GetAll();
                MessageBox.Show("Trainer added!!!");
            }
            catch (Exception)
            {
                MessageBox.Show("Some errors were found!");
            }
        }

        private void DeleteTrainer_Click(object sender, EventArgs e)
        {
            try
            {
                int delId = int.Parse(tbTrainersIDDel.Text);
                TrainerRepository.Del(delId);
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = TrainerRepository.GetAll();
                MessageBox.Show("Trainer deleted!!!");
            }
            catch (Exception)
            {
                MessageBox.Show("Some errors were found!");
            }
        }

        private void ClearTrainer_Click(object sender, EventArgs e)
        {
            tbNameTrainer.Text = "";
            tbExperienceTrainer.Text = "";
        }


        /* Hover */
        private void SaveTrainer_MouseHover(object sender, EventArgs e)
        {
            mouseHover(SaveTrainer);
        }

        private void ClearTrainer_MouseHover(object sender, EventArgs e)
        {
            mouseHover(ClearTrainer);
        }

        private void DeleteTrainer_MouseHover(object sender, EventArgs e)
        {
            mouseHover(DeleteTrainer);
        }


        /* Leave */
        private void SaveTrainer_MouseLeave(object sender, EventArgs e)
        {
            mouseLeave(SaveTrainer);
        }

        private void ClearTrainer_MouseLeave(object sender, EventArgs e)
        {
            mouseLeave(ClearTrainer);
        }

        private void DeleteTrainer_MouseLeave(object sender, EventArgs e)
        {
            mouseLeave(DeleteTrainer);
        }

    }
}
