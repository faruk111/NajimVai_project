using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResultCalculationApp
{
    public partial class ResultCalculationGUI : Form
    {
        public ResultCalculationGUI()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {

            double markOfPhysics = Convert.ToDouble(physicsTextButton.Text);
            double markOfChemestry = Convert.ToDouble(chemistryTextButton.Text);
            double markOfMath = Convert.ToDouble(mathTextButton.Text);
            Result aResult = new Result(markOfPhysics,markOfChemestry,markOfMath);

            double averageMark = aResult.CalculateAverage();

            averageTextButton.Text = averageMark.ToString();
            gradeTextButton.Text = aResult.CalculateGrade();
        }
    }
}
