using BodyForgeClient.Model;
using BodyForgeClient.WorkoutService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BodyForgeClient.Forms
{
    public partial class WorkoutMenu : Form
    {
        private WorkoutWebServiceSoapClient workoutService;
        private List<Workout> workouts;

        public WorkoutMenu()
        {
            InitializeComponent();
            workoutService = new WorkoutWebServiceSoapClient();
            populateWorkouts();
            populateWorkoutList();
        }

        private void workoutList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void populateWorkouts()
        {
            workouts = new List<Workout>();
            Console.WriteLine(CurrentUser.id);
            Workout[] getWorkouts = workoutService.getByUserId(CurrentUser.id);
            for (int i = 0; i < getWorkouts.Length; i++)
            {
                workouts.Add(getWorkouts[i]);
            }
        }

        private void populateWorkoutList()
        {
            workoutList.Items.Clear();
            for (int i = 0; i < workouts.Count; i++)
            {
                string w = workouts[i].name + " - " + workouts[i].workout_date.ToString("dd/MM/yyyy");
                workoutList.Items.Add(w);
            }
        }

        private void deleteWorkout_Click(object sender, EventArgs e)
        {
            int index = workoutList.SelectedIndex;
            workoutService.deleteWorkout(workouts[index].id);
            populateWorkouts();
            populateWorkoutList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WorkoutAdd workoutAdd = new WorkoutAdd();
            this.Hide();
            workoutAdd.ShowDialog();
        }
    }
}
