using System;
using System.Windows.Forms;

using Modbus.Device;

namespace ModbusRtuMasterEx
{
    public partial class MainForm : Form
    {
        private ModbusSerialMaster master;

        public MainForm()
        {
            InitializeComponent();
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn == btnOpen)
            {
                try
                {
                    sp.Open();
                    master = ModbusSerialMaster.CreateRtu(sp);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            else if (btn == btnClose)
            {
                sp.Close();
            }
        }

        private void OnRWButtonClicked(object sender, EventArgs e)
        {
            if (master == null) return;
            if (!sp.IsOpen) return;

            Button btn = sender as Button;

            if (btn == btnReadCoils)
            {
                bool[] bCoilArr = master.ReadCoils(1, 0, 10);

                foreach (var val in bCoilArr)
                {
                    Console.WriteLine(val);
                }
            }
            else if (btn == btnReadInputs)
            {
                bool[] bInputArr = master.ReadInputs(1, 0, 10);

                foreach (var val in bInputArr)
                {
                    Console.WriteLine(val);
                }
            }
            else if (btn == btnReadHoldingRegs)
            {
                ushort[] holdRes = master.ReadHoldingRegisters(1, 0, 10);

                foreach (var val in holdRes)
                {
                    Console.WriteLine(val);
                }
            }
            else if (btn == btnReadInputRegs)
            {
                ushort[] inoutRes = master.ReadInputRegisters(1, 0, 10);

                foreach (var val in inoutRes)
                {
                    Console.WriteLine(val);
                }
            }
            else if (btn == btnWriteCoil)
            {
                master.WriteSingleCoil(1, 0, true);
                master.WriteSingleCoil(1, 1, true);
                master.WriteSingleCoil(1, 2, true);
                master.WriteSingleCoil(1, 3, true);
                master.WriteSingleCoil(1, 4, true);
                master.WriteSingleCoil(1, 5, true);
                master.WriteSingleCoil(1, 6, true);
                master.WriteSingleCoil(1, 7, true);
                master.WriteSingleCoil(1, 8, true);
                master.WriteSingleCoil(1, 9, true);
            }
            else if (btn == btnWriteHoldingReg)
            {
                master.WriteSingleRegister(1, 0, 2);
                master.WriteSingleRegister(1, 1, 2);
                master.WriteSingleRegister(1, 2, 2);
                master.WriteSingleRegister(1, 3, 2);
                master.WriteSingleRegister(1, 4, 2);
                master.WriteSingleRegister(1, 5, 2);
                master.WriteSingleRegister(1, 6, 2);
                master.WriteSingleRegister(1, 7, 2);
                master.WriteSingleRegister(1, 8, 2);
                master.WriteSingleRegister(1, 9, 2);
            }
            else if (btn == btnWriteCoils)
            {
                bool[] arr = new bool[10];
                master.WriteMultipleCoils(1, 0, arr);
            }
            else if (btn == btnWriteHoldingRegs)
            {
                ushort[] arr = new ushort[10];
                master.WriteMultipleRegisters(1, 0, arr);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(sp.IsOpen)
            {
                sp.Close();
            }
        }
    }
}
