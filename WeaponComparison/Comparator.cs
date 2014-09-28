using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace WeaponComparison
{
    public partial class Comparator : Form
    {
        List<Weapon> weapons = new List<Weapon>();
        DropoffChart dropoffChartForm = new DropoffChart();

        public Comparator() {
            InitializeComponent();
        }

        private void loadCSVData() {
            // on load initially look for CSV file with information, if not found, show dialog
            List<string[]> lines = new List<string[]>();
            if (!File.Exists("weapons.csv")) {
                MessageBox.Show("Could not locate 'weapons.csv' please locate weapons data CSV file.", "Could not locate data", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "CSV|*.csv";
                open.Title = "Open CSV";
                DialogResult result = open.ShowDialog();
                if (result == DialogResult.OK) {
                    Console.WriteLine("Loading CSV file");
                    StreamReader reader = new StreamReader(open.FileName);
                    while (!reader.EndOfStream) {
                        string[] Line = reader.ReadLine().Split(',');
                        lines.Add(Line);
                    }
                } else {
                    Application.Exit();
                }
            } else {
                StreamReader reader = new StreamReader("weapons.csv");
                while (!reader.EndOfStream) {
                    string[] Line = reader.ReadLine().Split(',');
                    lines.Add(Line);
                }
            }

            // process
            int failed = 0;
            foreach (string[] entry in lines) {
                if (entry.Length == 18) {
                    try {
                        string name = entry[0];
                        WeaponClass type = (WeaponClass)Enum.Parse(typeof(WeaponClass), entry[1], true);
                        int rpm = int.Parse(entry[2]);
                        int velocity = int.Parse(entry[3]);
                        int distance = int.Parse(entry[4]);
                        double drop = double.Parse(entry[5]);
                        int magazineSize = int.Parse(entry[6]);
                        double reloadTime = double.Parse(entry[7]);
                        double fullReloadTime = double.Parse(entry[8]);
                        int recoilDecrease = int.Parse(entry[9]);
                        double firstShotMultiplier = double.Parse(entry[10]);
                        double recoilLeft = double.Parse(entry[11]);
                        double recoilUp = double.Parse(entry[12]);
                        double recoilRight = double.Parse(entry[13]);
                        double maxDamage = double.Parse(entry[14]);
                        double minDamage = double.Parse(entry[15]);
                        double dropStart = double.Parse(entry[16]);
                        double dropEnd = double.Parse(entry[17]);

                        weapons.Add(
                            new Weapon(name, type, rpm, velocity, distance, drop, magazineSize, reloadTime, fullReloadTime, recoilDecrease, firstShotMultiplier, recoilLeft, recoilUp, recoilRight, maxDamage, minDamage, dropStart, dropEnd)
                            );
                    } catch {
                        Console.WriteLine("Malformed line beginning with: " + entry[0]);
                        failed++;
                    }
                } else {
                    Console.WriteLine("Malformed line beginning with: " + entry[0]);
                    failed++;
                }
            }

            Console.WriteLine("Loaded " + weapons.Count + " weapons.");
            if (failed > 0) {
                MessageBox.Show(String.Format("Could not load {0} entries", failed), "Could not load Weapons", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateComparison() {
            // change the contents of each group box based on the selection
            if (weaponSelectionA.SelectedIndex != -1 && weaponSelectionB.SelectedIndex != -1) {
                Weapon A = weapons[weaponSelectionA.SelectedIndex];
                Weapon B = weapons[weaponSelectionB.SelectedIndex];

                // update chart
                updateChart(A, B);

                // remove items
                weaponAAttributes.Items.Clear();
                weaponBAttributes.Items.Clear();

                // set group names for identification
                weaponGroupA.Text = A.name;
                weaponGroupB.Text = B.name;

                // dump attributes
                weaponAAttributes.Items.AddRange(A.dumpAttributes());
                weaponBAttributes.Items.AddRange(B.dumpAttributes());
            } else {
                MessageBox.Show("Please select two weapons to compare.", "Two Weapons Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void updateChart(Weapon A, Weapon B) {
            // set chart
            Chart compareChart = dropoffChartForm.dropoffDamageChart;

            // set chart basics
            compareChart.Series.Clear();
            compareChart.ChartAreas[0].AxisX.Interval = 10.0;
            compareChart.ChartAreas[0].AxisX.Minimum = 0;
            compareChart.ChartAreas[0].AxisX.Maximum = 100;
            compareChart.ChartAreas[0].AxisX.Title = "Meters";
            compareChart.ChartAreas[0].AxisY.Title = "Damage per Bullet";
            
            // add A series
            compareChart.Series.Add(A.name);
            compareChart.Series[A.name].Points.DataBindXY(A.pointsX, A.pointsY);
            compareChart.Series[A.name].ChartType = SeriesChartType.Line;
            compareChart.Series[A.name].Color = Color.Red;

            // only add B series if it differs from A series
            if (A.name != B.name) {
                compareChart.Series.Add(B.name);
                compareChart.Series[B.name].Points.DataBindXY(B.pointsX, B.pointsY);
                compareChart.Series[B.name].ChartType = SeriesChartType.Line;
                compareChart.Series[B.name].Color = Color.Blue;
            }

            // finally, refresh the chart
            compareChart.Update();
        }

        private void Comparator_Load(object sender, EventArgs e) {
            // load data
            loadCSVData();

            // load selections
            weaponSelectionA.Items.AddRange(weapons.ToArray());
            weaponSelectionB.Items.AddRange(weapons.ToArray());

            // bring to front
            this.BringToFront();
        }

        private void compareBtn_Click(object sender, EventArgs e) {
            updateComparison();
        }

        private void showChartBtn_Click(object sender, EventArgs e) {
            if (dropoffChartForm.dropoffDamageChart.Series.Count == 0) {
                MessageBox.Show("No weapon charts to display, please select two weapons and press 'Compare'.", "No Chart Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else {
                if (!dropoffChartForm.Visible) {
                    dropoffChartForm.Show();
                } else {
                    // already open? bring it up
                    dropoffChartForm.BringToFront();
                }
            }
        }
    }
}
