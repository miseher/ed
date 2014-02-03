using System;
using Gtk;

//TODO Al hacer click en buttonSumar, sumar los números en entry1 y entry2 mostrando el resultado en entryResult

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
		buttonSumar.Clicked+=delegate{
		try{	
		string s1=entry1.Text;
		string s2=entry2.Text;
		
		
		double i1=double.Parse (s1);
		double i2=double.Parse (s2);
		
		entryResult.Text=Convert.ToString (i1+i2);
			}catch(System.FormatException){
				entry1.Text="introduce un numero";
				entry2.Text="introduce un numero";
				
			}
		};
		
	
	
	//Resta
	
	
	
		
		buttonResta.Clicked+=delegate{
		try{	
		string s1=entry1.Text;
		string s2=entry2.Text;
		
		
		double i1=double.Parse (s1);
		double i2=double.Parse (s2);
		
		entryResult.Text=Convert.ToString (i1-i2);
			}catch(System.FormatException){
				entry1.Text="introduce un numero";
				entry2.Text="introduce un numero";
			}
		};
		
	
	
	//Multiplicacion
	
	
		buttonMultiplicacion.Clicked+=delegate{
		try{	
		string s1=entry1.Text;
		string s2=entry2.Text;
		
		
		double i1=double.Parse (s1);
		double i2=double.Parse (s2);
		
		entryResult.Text=Convert.ToString (i1*i2);
			}catch(System.FormatException){
				entry1.Text="introduce un numero";
				entry2.Text="introduce un numero";
			}
		};
		
	
	}
	
	
		

	
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
}
