using OpenAI.Chat;

namespace VisionDestinator
{
    public partial class VisionDestinatorForm : Form
    {
        private string _targetImagePath = string.Empty;
        private bool _isApiSet = false;
        private string _apiKey = string.Empty;
        private ChatClient? _client = null;

        public VisionDestinatorForm () {
            InitializeComponent();
        }

        private void SelectImage (object sender, EventArgs e) {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:/Users/username/Pictures";
                openFileDialog.Filter = "�摜�t�@�C��(*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    SelectImageBox.Image = Image.FromFile(openFileDialog.FileName);
                }

                _targetImagePath = openFileDialog.FileName;
            }
        }

        private void GetAPIKey (object sender, EventArgs e) {
            if (_isApiSet)
            {
                MessageBox.Show("API�L�[�͂��łɐݒ肳��Ă��܂��B");
                return;
            }

            MessageBox.Show("API�L�[�̕ۑ�����Ă���t�@�C����I�����Ă��������B");

            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "API�L�[�̕ۑ�����Ă���t�@�C�����J��";
                dialog.Filter = "�e�L�X�g�t�@�C��(*.txt)|*.txt|���ׂẴt�@�C��(*.*)|*.*";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    _apiKey = File.ReadAllText(dialog.FileName);
                    _isApiSet = true;
                    _client = new ("gpt-4o", _apiKey);
                }
            }

            SetAPIBox.Enabled = false;
        }

        private async void GenerateAns (object sender, EventArgs e) {
            if(_client == null)
            {
                MessageBox.Show("API�L�[���ݒ肳��Ă��܂���B");
                return;
            }

            if (string.IsNullOrEmpty(_targetImagePath))
            {
                MessageBox.Show("�摜���I������Ă��܂���B");
                return;
            }

            string question = questionBox.Text;

            if(string.IsNullOrEmpty(question))
            {
                MessageBox.Show("���₪���͂���Ă��܂���B");
                return;
            }

            ImageSelector.Enabled = false;
            Generate.Enabled = false;


            string imageFilePath = Path.Combine("Assets", _targetImagePath);
            using Stream imageStream = File.OpenRead(imageFilePath);
            BinaryData imageBytes = BinaryData.FromStream(imageStream);

            List<ChatMessage> messages = [
                new UserChatMessage(
                ChatMessageContentPart.CreateTextMessageContentPart(question),
                ChatMessageContentPart.CreateImageMessageContentPart(imageBytes, "image/png"))
            ];

            ChatCompletion chatCompletion = await _client.CompleteChatAsync(messages);

            AnsBox.Text = chatCompletion.Content[0].Text;

            ImageSelector.Enabled = true;
            Generate.Enabled = true;
        }
    }
}
