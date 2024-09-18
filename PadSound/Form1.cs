using System;
using System.Windows.Forms;
using NAudio.Wave;

namespace PadSound
{
    public partial class Form1 : Form
    {
        private AudioFileReader audioFileReader;
        private WaveOutEvent outputDevice;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Audio Files|*.mp3;*.wav;*.aac;*.flac";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtAudioFile.Text = $"{openFileDialog.FileName}";
                    LoadAudio(openFileDialog.FileName);
                }
            }
        }
        private void LoadAudio(string filePath)
        {
            outputDevice?.Stop();
            audioFileReader = new AudioFileReader(filePath);
            outputDevice = new WaveOutEvent();
            if (checkBox1.Checked)
                outputDevice.DeviceNumber = 0;

            if (checkBox2.Checked)
                outputDevice.DeviceNumber = 1;

            outputDevice.Init(audioFileReader);
        }

        private void btnPlay_Click_Click(object sender, EventArgs e)
        {
            outputDevice?.Play();

        }

        private void btnPause_Click_Click(object sender, EventArgs e)
        {
            outputDevice?.Pause();
        }

        private void btnStop_Click_Click(object sender, EventArgs e)
        {
            outputDevice?.Stop();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            outputDevice?.Dispose();
            audioFileReader?.Dispose();
            base.OnFormClosing(e);
        }
    }
}
