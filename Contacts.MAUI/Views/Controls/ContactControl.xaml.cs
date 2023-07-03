namespace Contacts.MAUI.Views.Controls;

public partial class ContactControl : ContentView
{
    public event EventHandler<string> OnError;
    public event EventHandler<EventArgs> OnSave;
    public event EventHandler<EventArgs> OnCancel;


    public ContactControl()
	{
		InitializeComponent();
	}

	public string FirstName
	{
		get
		{
			return entry_firstName.Text;
		}
		set
		{
			entry_firstName.Text = value;

        }
	}
    public string LastName
    {
        get
        {
            return entry_lastName.Text;
        }
        set
        {
            entry_lastName.Text = value;

        }
    }
    public string Mobile
    {
        get
        {
            return entry_mobile.Text;
        }
        set
        {
            entry_mobile.Text = value;

        }
    }
    public string Email
    {
        get
        {
            return entry_email.Text;
        }
        set
        {
            entry_email.Text = value;

        }
    }


    private void btnCancel_Clicked(System.Object sender, System.EventArgs e)
    {
        OnSave?.Invoke(sender, e);
        
    }

    private void btnSave_Clicked(System.Object sender, System.EventArgs e)
    {

        if (firstName_Validator.IsNotValid)
        {
            OnError?.Invoke(sender, "First name is too short.");
            //DisplayAlert("Error!", "First name is too short.", "OK");
            return;
        }

        if (email_Validator.IsNotValid)
        {
            foreach (var error in email_Validator.Errors)
            {
                OnError?.Invoke(sender, error.ToString());
                //DisplayAlert("Error!", error.ToString(), "OK");
            }
            return;
        }
        OnSave?.Invoke(sender, e);
        
    }

}
