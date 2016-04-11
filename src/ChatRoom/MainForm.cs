using System;
using System.Drawing;
using System.Windows.Forms;

namespace ChatRoom
{
	public partial class MainForm : Form
	{
		private enum MessageSource
		{
			MyMessage = 0,
			WebMessage = 1,
		}

		private sealed class MessageController
		{
			public string Message { get; set; }

			public MessageSource Source { get; set; }
		}

		private sealed class OptionsListBox : ListBox
		{
			protected override void OnDrawItem(DrawItemEventArgs e)
			{
				var controller = (MessageController)Items[e.Index];

				if(controller != null)
				{
					switch(controller.Source)
					{
						case MessageSource.WebMessage:
							{
								break;
							}
						default:
						case MessageSource.MyMessage:
							{
								break;
							}
					}
				}

				base.OnDrawItem(e);
			}
		}

		#region Properties

		private MessageValidator Validator { get; }

		private string Message
		{
			get { return _txtMessage.Text; }
		}

		#endregion

		public MainForm()
		{
			Validator = new MessageValidator();

			InitializeComponent();

			Font = SystemFonts.MessageBoxFont;

			_lblMessage.Text = string.Empty;
		}

		#region override

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			MinimumSize = Size;

			ValidateMessage();
		}

		#endregion


		private void _btnDelete_Click(object sender, EventArgs e)
		{
			for(int i = _lstMessageList.SelectedItems.Count - 1; i >= 0; i--)
			{
				_lstMessageList.Items.Remove(_lstMessageList.SelectedItems[i]);
			}
		}

		private void _btnOK_Click(object sender, EventArgs e)
		{
			if(this._txtMessage.Text != string.Empty)
			{
				_lstMessageList.Items.Add(/*new MessageController { Message = _txtMessage.Text, Source = MessageSource.MyMessage }*/_txtMessage.Text);
				_txtMessage.Text = null;
			}
		}

		private void ChangeTextBox(object sender, EventArgs e)
		{
	   
		}

		private void ValidateMessage()
		{
			var result = Validator.ValidateMessage(Message);

			if(!result.Success)
			{
				_txtMessage.ForeColor = Color.Red;
			}
			else
			{
				_txtMessage.ForeColor = SystemColors.ControlText;
			}

			_lblMessage.Text = $@"Сообщений: {result.MessageCount}. Символов: {result.CharsCount}.";
		}

		private void OnMessageTextChanged(object sender, EventArgs e)
		{
			ValidateMessage();
		}
	}
}
