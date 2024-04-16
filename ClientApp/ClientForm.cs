using System;
using System.ServiceModel;
using System.Windows.Forms;

namespace ClientApp
{
	public partial class ClientForm : Form
	{
		public ClientForm()
		{
			InitializeComponent();
		}

		int rowStarVelocity = 0;
		int rowStarDistance = 0;
		int rowKelvin = 0;
		int rowEventHorizon = 0;

		private void ButtonCalculate_Click(object sender, System.EventArgs e)
		{
			DataGridViewOutput.Rows.Add(1);

			if (!string.IsNullOrEmpty(TextBoxInputWavelengthObserved.Text) && !string.IsNullOrEmpty(TextBoxInputWavelengthRest.Text))
			{
				double observed = double.Parse(TextBoxInputWavelengthObserved.Text);
				double rest = double.Parse(TextBoxInputWavelengthRest.Text);
				StarVelocity(observed, rest);
			}

			if (!string.IsNullOrEmpty(TextBoxInputParallax.Text))
			{
				double parallax = double.Parse(TextBoxInputParallax.Text);
				StarDistance(parallax);
			}

			if (!string.IsNullOrEmpty(TextBoxInputCelsius.Text))
			{
				double celsius = double.Parse(TextBoxInputCelsius.Text);
				Kelvin(celsius);
			}

			if (!string.IsNullOrEmpty(TextBoxInputMass.Text))
			{
				double mass = double.Parse(TextBoxInputMass.Text) * Math.Pow(10, (double)NumericUpDownInputMass.Value);
				EventHorizon(mass);
			}
		}

		private void StarVelocity(double observed, double rest)
		{
			// set base address
			string address = "net.pipe://localhost/pipeformulas";

			// create NetNamedPipeBinding instance
			NetNamedPipeBinding binding = new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);

			// create EndpointAddress instance
			EndpointAddress ep = new EndpointAddress(address);

			// create a channel to the server
			IAstroContract channel = ChannelFactory<IAstroContract>.CreateChannel(binding, ep);

			// calculate star velocity
			double velocity = channel.StarVelocity(observed, rest);

			// round and add value to DataGridViewOutput column Star Velocity
			DataGridViewOutput[0, rowStarVelocity].Value = Math.Round(velocity, 0);

			// increase row counter
			rowStarVelocity++;
		}

		private void StarDistance(double parallax)
		{
			// set base address
			string address = "net.pipe://localhost/pipeformulas";

			// create NetNamedPipeBinding instance
			NetNamedPipeBinding binding = new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);

			// create EndpointAddress instance
			EndpointAddress ep = new EndpointAddress(address);

			// create a channel to the server
			IAstroContract channel = ChannelFactory<IAstroContract>.CreateChannel(binding, ep);

			// calculate star distance
			double distance = channel.StarDistance(parallax);

			// round and add value to DataGridViewOutput column Star Distance
			DataGridViewOutput[1, rowStarDistance].Value = Math.Round(distance, 2);

			// increase row counter
			rowStarDistance++;
		}

		private void Kelvin(double celsius)
		{
			// set base address
			string address = "net.pipe://localhost/pipeformulas";

			// create NetNamedPipeBinding instance
			NetNamedPipeBinding binding = new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);

			// create EndpointAddress instance
			EndpointAddress ep = new EndpointAddress(address);

			// create a channel to the server
			IAstroContract channel = ChannelFactory<IAstroContract>.CreateChannel(binding, ep);

			// calculate Kelvin temperature
			double kelvin = channel.Kelvin(celsius);

			// round and add value to DataGridViewOutput column Kelvin
			DataGridViewOutput[2, rowKelvin].Value = kelvin;

			// increase row counter
			rowKelvin++;
		}

		private void EventHorizon(double mass)
		{
			// set base address
			string address = "net.pipe://localhost/pipeformulas";

			// create NetNamedPipeBinding instance
			NetNamedPipeBinding binding = new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);

			// create EndpointAddress instance
			EndpointAddress ep = new EndpointAddress(address);

			// create a channel to the server
			IAstroContract channel = ChannelFactory<IAstroContract>.CreateChannel(binding, ep);

			// calculate event horizon
			double radius = channel.EventHorizon(mass);

			DataGridViewOutput[3, rowEventHorizon].Value = radius.ToString("E1");

			// increase row counter
			rowEventHorizon++;
		}
	}
}
