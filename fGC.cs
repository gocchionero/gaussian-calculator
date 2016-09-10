using Quant;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaussianCalculator
{
    public partial class fGC : Form
    {
        public fGC()
        {
            InitializeComponent();
        }

        public void Clear(object sender, EventArgs e)
        {
            var mb = MessageBox.Show("Are you sure you want to clear all data?", "Clear", MessageBoxButtons.YesNo);
            if (mb== System.Windows.Forms.DialogResult.Yes) dgwData.Rows.Clear();
        }

        public void Evolve(object sender, EventArgs e)
        {
            dgwData.AllowUserToAddRows = false;
            try
            {
                 var gl= GaussianList();
                 var cl = CoefficientList();
                 if (gl.Count < cl.Count)
                 {
                     MessageBox.Show("Gaussians are less than coefficients!", "Evolve", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     return;
                 }
                 else
                 {
                   int steps = int.Parse(tbSteps.Text);
                   for (int i = 0; i < steps; i++)
                   {
                     gl = gl.Skip(gl.Count - cl.Count).ToList();
                     var ng = gl.Zip(cl, (g, c) => c * g).Aggregate(new Gaussian(0, 0), (a, p) => a + p);
                     gl.Add(ng);
                     dgwData.Rows.Add(ng.Avg, ng.StDev);
                   }
                 }
            }
            catch (Exception)
            {
                MessageBox.Show("Error!", "Evolve", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dgwData.AllowUserToAddRows = true;
        }

        private List<double> CoefficientList()
        {
            var cl = new List<double>();
            try
            {
                for (int i = 0; i < dgwData.Rows.Count; i++)
                {
                    if (dgwData.Rows[i].Cells[2].Value == null) break;
                    var coeff = double.Parse(dgwData.Rows[i].Cells[2].Value.ToString());
                    cl.Add(coeff);
                }
            }
            catch (Exception) 
            {
                return null;
            }
            return cl;
        }
        
        private List<Gaussian> GaussianList()
        {
            var gl = new List<Gaussian>();
            try
            {
                for (int i = 0; i < dgwData.Rows.Count; i++)
                {
                    if (dgwData.Rows[i].Cells[0].Value == null) break;
                    var avg = double.Parse(dgwData.Rows[i].Cells[0].Value.ToString());
                    var stdev = double.Parse(dgwData.Rows[i].Cells[1].Value.ToString());
                    gl.Add(new Gaussian(avg, stdev));
                }
            }
            catch (Exception) 
            {
                return null;
            }
            return gl;
        }
    }
}
