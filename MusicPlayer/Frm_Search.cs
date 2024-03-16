using System;
using System.Windows.Forms;
using SpotifyExplode;
using SpotifyExplode.Search;
using System.Diagnostics;
using System.IO;
using VideoLibrary;
using NReco.VideoConverter;

namespace MusicPlayer
{
    public partial class Frm_Search : Form
    {
        public Frm_Search()
        {
            InitializeComponent();
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();

            try
            {
                var spotify = new SpotifyClient();
                var searchResults = await spotify.Search.GetResultsAsync(searchText);

                dataGridView1.Rows.Clear();

                foreach (var result in searchResults)
                {
                    switch (result)
                    {
                        case TrackSearchResult track:
                            string formattedDuration = ConvertMillisecondsToTimeFormat(Convert.ToInt32(track.DurationMs));
                            dataGridView1.Rows.Add(track.Id, track.Title, formattedDuration);
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ConvertMillisecondsToTimeFormat(int milliseconds)
        {
            TimeSpan time = TimeSpan.FromMilliseconds(milliseconds);
            return time.ToString(@"mm\:ss");
        }

        private async void btnPlay_Click(object sender, EventArgs e)
        {
            try
            {
                var row = dataGridView1.SelectedRows[0];

                var id = row.Cells["ID"].Value;
                string OpenUrl = $"https://open.spotify.com/track/{id}";

                using (var webClient = new System.Net.WebClient())
                {
                    Process.Start(OpenUrl);
                }
            }
            catch (Exception ex)
            {
                // Provide more informative error messages
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetDownloadLabelText(string text)
        {
            if (lblDownload.InvokeRequired)
            {
                lblDownload.Invoke((MethodInvoker)delegate { lblDownload.Text = text; });
            }
            else
            {
                lblDownload.Text = text;
            }
        }

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            try
            {
                var spotify = new SpotifyClient();
                // Access required elements
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                string id = row.Cells["ID"].Value.ToString();  // Ensure ToString() for string conversion

                // Retrieve YouTube ID from Spotify
                string youtubeId = await spotify.Tracks.GetYoutubeIdAsync($"https://open.spotify.com/track/{id}").ConfigureAwait(false);

                // Validate YouTube ID before proceeding
                if (!string.IsNullOrEmpty(youtubeId))
                {
                    string youtubeUrl = $"https://youtube.com/watch?v={youtubeId}";

                    // Download the video using YouTube library
                    var source = @"D:\Music\Download";
                    var youtube = YouTube.Default;

                    SetDownloadLabelText("Downloading... Please wait");
                    var vid = await youtube.GetVideoAsync(youtubeUrl).ConfigureAwait(false);  // Use async for download
                    
                    // Handle potential errors during video download
                    if (vid == null)
                    {
                        throw new Exception("Failed to download video from YouTube.");
                    }

                    string videoFilePath = Path.Combine(source, vid.FullName);
                    File.WriteAllBytes(videoFilePath, vid.GetBytes());

                    // Convert the video to audio using FFmpeg
                    var ffmpeg = new FFMpegConverter();
                    var audioFilePath = $"{videoFilePath}.mp3";

                    // Convert video to audio (MP3)
                    ffmpeg.ConvertMedia(videoFilePath, audioFilePath, "mp3");

                    // Clean up - remove the original video file
                    File.Delete(videoFilePath);
                    SetDownloadLabelText("");
                    MessageBox.Show("Audio downloaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to retrieve YouTube ID from Spotify.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SetDownloadLabelText("");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetDownloadLabelText("");
            }
        }

    }

}
