using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Toastmasters
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{	


		public MainWindow()
		{
			InitializeComponent();

			//adding a clock to the application
			DispatcherTimer clocktime = new DispatcherTimer();
			clocktime.Interval = new TimeSpan(0, 0, 1);
			clocktime.Tick += clocktime_tick;
			clocktime.Start();
		}

		private void clocktime_tick(object sender, EventArgs e)
		{
			timerbox.Text = DateTime.Now.ToLongTimeString();
		}

		private void Joke_of_the_day(object sender, RoutedEventArgs e)
		{
			string[] joke = new string[100];
			joke[0] = "Parallel lines have so much in common. It’s a shame they’ll never meet.";
			joke[1] = "I called a psychic once. She asked who was on the line, so I hung up.";
			joke[2] = "My wife accused me of being immature. I told her to get out of my fort.";
			joke[3] = "I tried to catch fog yesterday, Mist.";
			joke[4] = "Mom, can I have an animal cracker?” asked 3 year old Bob. “Sure Bob,” said his mom. " +
				"Open up the box, and take a few. Forty five minutes later Bob’s mother walked into the kitchen. " +
				"Bob, why’d you spill out all of the animal crackers, and what are you looking for?” “It said on " +
				"the box not to eat it if the seal is broken.” Bob replied “I spilled out the whole box, I looked " +
				"through all of the animals but I can’t find any seals!";
			joke[5] = "";
			joke[6] = "";
			joke[7] = "";
			joke[8] = "";
			joke[9] = "";
			joke[10] = "";
			joke[11] = "";
			joke[12] = "";
			joke[13] = "";

			Random rnd = new Random();
			joketextbox.Text = (joke[rnd.Next(0, 5)]);
		}

		private void Word_of_the_day_Click(object sender, RoutedEventArgs e)
		{
			string[] word = new string[100];
			word[0] = "Oftentimes: Adverb. Often or repeatedly";
			word[1] = "Penchant: Noun. A strong or continued inclination";
			word[2] = "Incoherent: Adjective. Lacking clarity or intelligibility";
			word[3] = "Nudnik \n\n " +
				"Noun. A person who is a bore or nuisance\n\n" +
				"James worried that he would never finish his work if the office nudnik" +
				" didn't quit hanging around his cubicle.";
			word[4] = "Affable \n\n" +
				"Adjective. Being pleasant and at ease when talking to others \n\n" +
				"Example: Michelle looked forward to sharing her coffee breaks with Joe, " +
				"one of her more affable coworkers.";

			Random rnd = new Random();
			word_of_the_day.Text = (word[rnd.Next(0,5)]);
		}

		private void Table_Topics_Click(object sender, RoutedEventArgs e)
		{
			string[] topic = new string[100];
			topic[0] = "Who in your family does the wackiest things?";
			topic[1] = "What was your favorite movie when you were young?";
			topic[2] = "What’s the biggest question you have about the future?";
			topic[3] = "What habit would you like to break?";
			topic[4] = "The worst colour";
			topic[5] = "Has a stranger ever bought you a drink?";
			topic[6] = "If you had a superpower, what would it be?";
			topic[7] = "There is a movie based on your life. Who is the star?";
			topic[8] = "If you could outlaw one vegetable, which one would it be?";
			topic[9] = "What did you get into trouble for most as a child?";
			topic[10] = "If you could rename yourself what name would you choose?";
			topic[11] = "What has been your biggest accomplishment in life so far?";
			topic[12] = "If you could have any talent that you don't have, what would it be?";
			topic[13] = "What can you do today that you weren’t capable of a year ago?";
			topic[14] = "Irrational fears";
			topic[15] = "Smart phones";
			topic[16] = "Breakfast for dinner";
			topic[17] = "Do you consider yourself to be an introvert or extrovert?";

			Random rnd = new Random();
			table_topic.Text= (topic[rnd.Next(0, 17)]);
		}

	}
}
