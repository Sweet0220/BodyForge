
using BodyForgeClient.ExerciseService;
using BodyForgeClient.MuscleService;
using BodyForgeClient.TargetService;
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
    
    public partial class WorkoutAdd : Form
    {
        private MuscleWebServiceSoapClient muscleService;
        private TargetWebServiceSoapClient targetService;
        private ExerciseWebServiceSoapClient exerciseService;
        private List<Muscle> muscles;
        private List<Target> targets;
        private List<Exercise> exercises;
        public WorkoutAdd()
        {
            InitializeComponent();
            muscleService = new MuscleWebServiceSoapClient();
            targetService = new TargetWebServiceSoapClient();
            exerciseService = new ExerciseWebServiceSoapClient();
            getMuscles();
            populateMuscleList();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void getMuscles()
        {
            muscles = new List<Muscle>();
            Muscle[] m = muscleService.getAll();
            for (int i = 0; i < m.Length; i++)
            {
                muscles.Add(m[i]);
            }
        }

        private void populateMuscleList()
        {
            muscleList.Items.Clear();
            for (int i = 0; i < muscles.Count; i++)
            {
                muscleList.Items.Add(muscles[i].name);
            }
        }

        private void muscleList_SelectedIndexChanged(object sender, EventArgs e)
        {
            exerciseList.Items.Clear();
            targets = new List<Target>();
            exercises = new List<Exercise>();
            int index = muscleList.SelectedIndex;
            Target[] t = targetService.getByMuscleId(muscles[index].id);
            for (int i = 0; i < t.Length; i++) 
            {
                targets.Add(t[i]);
            }
            for (int i = 0; i < targets.Count; i++)
            {
                Exercise ex = exerciseService.getById(targets[i].id_exercise);
                exercises.Add(ex);
                exerciseList.Items.Add(ex.name);
            }
        }
    }
}
