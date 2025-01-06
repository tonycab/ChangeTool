using ABB.Robotics.Math;
using ABB.Robotics.RobotStudio;
using ABB.Robotics.RobotStudio.Stations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;

namespace ChangeTool
{
    /// <summary>
    /// Code-behind class for the ChangeTool Smart Component.
    /// </summary>
    /// <remarks>
    /// The code-behind class should be seen as a service provider used by the 
    /// Smart Component runtime. Only one instance of the code-behind class
    /// is created, regardless of how many instances there are of the associated
    /// Smart Component.
    /// Therefore, the code-behind class should not store any state information.
    /// Instead, use the SmartComponent.StateCache collection.
    /// </remarks>
    public class CodeBehind : SmartComponentCodeBehind
    {
        /// <summary>
        /// Called when the value of a dynamic property value has changed.
        /// </summary>
        /// <param name="component"> Component that owns the changed property. </param>
        /// <param name="changedProperty"> Changed property. </param>
        /// <param name="oldValue"> Previous value of the changed property. </param>
        public override void OnPropertyValueChanged(SmartComponent component, DynamicProperty changedProperty, Object oldValue)
        {
        }


        /// <summary>
        /// Called when the value of an I/O signal value has changed.
        /// </summary>
        /// <param name="component"> Component that owns the changed signal. </param>
        /// <param name="changedSignal"> Changed signal. </param>
        public override void OnIOSignalValueChanged(SmartComponent component, IOSignal changedSignal)
        {
        
            if (changedSignal.Name == "GI_OUTIL_NUMBER"){
                changeToolView(component, (uint)changedSignal.Value);
            }
        }

        public override void OnSimulationStart(SmartComponent component)
        {
            changeToolView(component, (uint)component.IOSignals["GI_OUTIL_NUMBER"].Value);
        }

        /// <summary>
        /// Called during simulation.
        /// </summary>
        /// <param name="component"> Simulated component. </param>
        /// <param name="simulationTime"> Time (in ms) for the current simulation step. </param>
        /// <param name="previousTime"> Time (in ms) for the previous simulation step. </param>
        /// <remarks>
        /// For this method to be called, the component must be marked with
        /// simulate="true" in the xml file.
        /// </remarks>
        public override void OnSimulationStep(SmartComponent component, double simulationTime, double previousTime)
        {
        }


        public void changeToolView(SmartComponent component, uint number)
        {
            try
            {

                ProjectObjectTag Tool_1_Robot = (ProjectObjectTag)component.Properties["Tool_1_Robot"].Value;
                ProjectObjectTag Tool_2_Robot = (ProjectObjectTag)component.Properties["Tool_2_Robot"].Value;
                ProjectObjectTag Tool_3_Robot = (ProjectObjectTag)component.Properties["Tool_3_Robot"].Value;
                ProjectObjectTag Tool_4_Robot = (ProjectObjectTag)component.Properties["Tool_4_Robot"].Value;
                ProjectObjectTag Tool_5_Robot = (ProjectObjectTag)component.Properties["Tool_5_Robot"].Value;
                ProjectObjectTag Tool_6_Robot = (ProjectObjectTag)component.Properties["Tool_6_Robot"].Value;


                if ((uint)number == 0)
                {
                    if (Tool_1_Robot != null) Tool_1_Robot.Visible = false;
                    if (Tool_2_Robot != null) Tool_2_Robot.Visible = false;
                    if (Tool_3_Robot != null) Tool_3_Robot.Visible = false;
                    if (Tool_4_Robot != null) Tool_4_Robot.Visible = false;
                    if (Tool_5_Robot != null) Tool_5_Robot.Visible = false;
                    if (Tool_6_Robot != null) Tool_6_Robot.Visible = false;
                }
                if ((uint)number == 1)
                {
                    if (Tool_1_Robot != null) Tool_1_Robot.Visible = true;
                    if (Tool_2_Robot != null) Tool_2_Robot.Visible = false;
                    if (Tool_3_Robot != null) Tool_3_Robot.Visible = false;
                    if (Tool_4_Robot != null) Tool_4_Robot.Visible = false;
                    if (Tool_5_Robot != null) Tool_5_Robot.Visible = false;
                    if (Tool_6_Robot != null) Tool_6_Robot.Visible = false;
                }
                if ((uint)number == 2)
                {
                    if (Tool_1_Robot != null) Tool_1_Robot.Visible = false;
                    if (Tool_2_Robot != null) Tool_2_Robot.Visible = true;
                    if (Tool_3_Robot != null) Tool_3_Robot.Visible = false;
                    if (Tool_4_Robot != null) Tool_4_Robot.Visible = false;
                    if (Tool_5_Robot != null) Tool_5_Robot.Visible = false;
                    if (Tool_6_Robot != null) Tool_6_Robot.Visible = false;
                }
                if ((uint)number == 3)
                {
                    if (Tool_1_Robot != null) Tool_1_Robot.Visible = false;
                    if (Tool_2_Robot != null) Tool_2_Robot.Visible = false;
                    if (Tool_3_Robot != null) Tool_3_Robot.Visible = true;
                    if (Tool_4_Robot != null) Tool_4_Robot.Visible = false;
                    if (Tool_5_Robot != null) Tool_5_Robot.Visible = false;
                    if (Tool_6_Robot != null) Tool_6_Robot.Visible = false;
                }
                if ((uint)number == 4)
                {
                    if (Tool_1_Robot != null) Tool_1_Robot.Visible = false;
                    if (Tool_2_Robot != null) Tool_2_Robot.Visible = false;
                    if (Tool_3_Robot != null) Tool_3_Robot.Visible = false;
                    if (Tool_4_Robot != null) Tool_4_Robot.Visible = true;
                    if (Tool_5_Robot != null) Tool_5_Robot.Visible = false;
                    if (Tool_6_Robot != null) Tool_6_Robot.Visible = false;
                }
                if ((uint)number == 5)
                {
                    if (Tool_1_Robot != null) Tool_1_Robot.Visible = false;
                    if (Tool_2_Robot != null) Tool_2_Robot.Visible = false;
                    if (Tool_3_Robot != null) Tool_3_Robot.Visible = false;
                    if (Tool_4_Robot != null) Tool_4_Robot.Visible = false;
                    if (Tool_5_Robot != null) Tool_5_Robot.Visible = true;
                    if (Tool_6_Robot != null) Tool_6_Robot.Visible = false;
                }

                if ((uint)number == 6)
                {
                    if (Tool_1_Robot != null) Tool_1_Robot.Visible = false;
                    if (Tool_2_Robot != null) Tool_2_Robot.Visible = false;
                    if (Tool_3_Robot != null) Tool_3_Robot.Visible = false;
                    if (Tool_4_Robot != null) Tool_4_Robot.Visible = false;
                    if (Tool_5_Robot != null) Tool_5_Robot.Visible = false;
                    if (Tool_6_Robot != null) Tool_6_Robot.Visible = true;
                }


            }
            catch
            {

                MessageBox.Show("ToolChange selected only tag (No graphiq object");

            }

        }
    }
}
