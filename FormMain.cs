using Memory;

namespace RICOTrainer
{
    public partial class FormMain : Form
    {
        public Mem MemLib = new();
        int gameProcId;

        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenGame();
        }

        /// <summary>
        /// Enables or disables all clickable checkboxes
        /// </summary>
        /// <param name="toggle">true if it should be turned on</param>
        private void ToggleBoxes(bool toggle)
        {
            ammoCheckbox.Enabled = toggle;
            healthCheckbox.Enabled = toggle;
            status.Text = toggle ? "Game Found!" : "not Found!";
            status.ForeColor = toggle ? Color.Green : Color.Red;
        }

        /// <summary>
        /// Try to find the open game in all process
        /// </summary>
        private void OpenGame()
        {
            gameProcId = MemLib.GetProcIdFromName("RICO");
            MemLib.OpenProcess(gameProcId);

            if (gameProcId > 0)
                MemLib.OpenProcess("RICO");

            if (MemLib.OpenProcess("RICO") == true)
            {
                ToggleBoxes(true);
                MemLib.mProc.Process.Exited += CloseGame;
            }
        }

        /// <summary>
        /// Injects Array of Bytes in a offset
        /// </summary>
        /// <param name="offset">+offset of the exe or dll</param>
        /// <param name="bytes">the bytes that should be injected</param>
        private void ApplyAOB(string offset, string bytes)
        {
            MemLib.WriteMemory($"GameAssembly.dll+{offset}", "bytes", bytes);
        }

        /// <summary>
        /// Ammo Checkbox Action
        /// </summary>
        private void AmmoCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            ApplyAOB("19A5AE4", ammoCheckbox.Checked ? "90 90 90 90 90" : "29 46 20 75 11");
        }

        /// <summary>
        /// Health Checkbox Action
        /// </summary>
        private void HealthCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            ApplyAOB("47A9E4", healthCheckbox.Checked ? "90 90 90 90 90" : "89 46 6C 5F 5E");
        }
        
        /// <summary>
        /// Timer to check if the game is open
        /// </summary>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (gameProcId == 0)
                OpenGame();
        }

        /// <summary>
        /// Action after closing the game, reset the conditions.
        /// </summary>
        private void CloseGame(object? sender, EventArgs e)
        {
            gameProcId = 0;
            ToggleBoxes(false);

            MemLib.mProc.Process.Exited -= CloseGame;
        }
    }
}
