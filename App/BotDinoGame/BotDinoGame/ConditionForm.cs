using BotDinoGame.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BotDinoGame
{
    public partial class ConditionForm : Form
    {
        private ProcessModel result;
        public ConditionForm(Rectangle rect)
        {
            InitializeComponent();
            init(rect);
        }

        private void init(Rectangle rect)
        {
            result = new ProcessModel();
            result.rect = rect;
            #region show rect
            labelShowRect.Text = string.Format("x:{0}, y:{1}, w:{2}, h:{3}", rect.X, rect.Y, rect.Width, rect.Height);
            #endregion end show rect
            #region action combobox
            BindingList<ActionChoice> listActionObjects = new BindingList<ActionChoice>();

            ActionChoice upAction = new ActionChoice();
            upAction.Name = "UP";
            upAction.Value = ActionModel.UP;

            ActionChoice downAction = new ActionChoice();
            downAction.Name = "Down";
            downAction.Value = ActionModel.DOWN;

            listActionObjects.Add(upAction);
            listActionObjects.Add(downAction);

            comboBoxAction.ValueMember = null;
            comboBoxAction.DisplayMember = "Name";
            comboBoxAction.DataSource = listActionObjects;
            comboBoxAction.TabIndex = 0;
            #endregion end action combobox


            #region operation combobox
            BindingList<OperationChoice> listOperationObjects = new BindingList<OperationChoice>();

            OperationChoice gtOperation = new OperationChoice();
            gtOperation.Name = "Greater than";
            gtOperation.Value = OperationModel.GreaterThan;

            OperationChoice ltOperation = new OperationChoice();
            ltOperation.Name = "Less than";
            ltOperation.Value = OperationModel.LessThan;

            listOperationObjects.Add(gtOperation);
            listOperationObjects.Add(ltOperation);

            comboBoxOperation.ValueMember = null;
            comboBoxOperation.DisplayMember = "Name";
            comboBoxOperation.DataSource = listOperationObjects;
            comboBoxOperation.TabIndex = 0;
            #endregion end operation combobox
        }


        public class ActionChoice
        {
            public string Name { get; set; }
            public ActionModel Value { get; set; }
        }

        public class OperationChoice
        {
            public string Name { get; set; }
            public OperationModel Value { get; set; }
        }

        public ProcessModel getResultData()
        {
            if (result != null)
            {
                return result;
            }
            return new ProcessModel();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            double threshold;
            if (double.TryParse(textBoxInputThreshold.Text, out threshold))
            {
                result.threshold = threshold;
            }

            if (comboBoxAction.SelectedValue != null)
            {
                ActionChoice currentAction = (ActionChoice)comboBoxAction.SelectedValue;
                result.action = currentAction.Value;
            }

            if (comboBoxOperation.SelectedValue != null)
            {
                OperationChoice currentOperation = (OperationChoice)comboBoxOperation.SelectedValue;
                result.operaion = currentOperation.Value;
            }
        }
    }
}
