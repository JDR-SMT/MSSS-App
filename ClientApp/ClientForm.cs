using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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

		// global variables
		DataTable dataTable = new DataTable();
		Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
		List<string> listVelocity = new List<string>();
		List<string> listDistance = new List<string>();
		List<string> listKelvin = new List<string>();
		List<string> listRadius = new List<string>();

		private void PopulateDataTable()
		{
			// clear dictionary and data table
			dictionary.Clear();
			dataTable.Columns.Clear();
			dataTable.Clear();

			// add column names with associated lists to dictionary
			dictionary.Add("Star Velocity", listVelocity);
			dictionary.Add("Star Distance", listDistance);
			dictionary.Add("Kelvin", listKelvin);
			dictionary.Add("Event Horizon", listRadius);

			// add data table columns using dictionary keys
			foreach (var key in dictionary.Keys)
			{
				dataTable.Columns.Add(key);
			}

			// count each list in the dictionary and return the max number of rows
			int count = dictionary.Values.Max(list => list.Count);

			// add the list associated with the dictionary key to the data table
			for (int i = 0; i < count; i++)
			{
				var row = dataTable.Rows.Add();

				foreach (var key in dictionary.Keys)
				{
					try
					{
						row[key] = dictionary[key][i];
					}
					// if list associated with dictionary key is empty
					catch
					{
						row[key] = null;
					}
				}
			}

			// set data table as data source
			DataGridViewOutput.DataSource = dataTable;
		}

		private void ButtonCalculate_Click(object sender, EventArgs e)
		{
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

			// round and add value to list as string
			listVelocity.Add(Math.Round(velocity, 0).ToString());

			PopulateDataTable();
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

			// round and add value to list as string
			listDistance.Add(Math.Round(distance, 2).ToString());

			PopulateDataTable();
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

			// add value to list as string
			listKelvin.Add(kelvin.ToString());

			PopulateDataTable();
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

			// format and add value to list as string
			listRadius.Add(radius.ToString("E1"));

			PopulateDataTable();
		}
	}
}
