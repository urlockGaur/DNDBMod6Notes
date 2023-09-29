using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTemplate
{
    internal class Test
    {
       
        
        public void Method()
        { //have to cast using the abstract class - see blow
            Media m1 = new Movie();
            //cast safe cast - as = trust me bro compiler mane. don't worry about me homie.
            (m1 as Movie).Name = "";
            // alt way to cast - could crash if title not truly part of media. compiler makes decision. must have solid code - use this method
            ((Movie)m1).Title = "";
            ((Movie)m1).Purchase();

            Media m2 = new Show();
            ((Show)m2).Name = "";
            ((Show)m2).Year = "";
            ((Show)m2).Display();
            ((Show)m2).Purchase();

            Media m3 = new Video();
            ((Video)m3).Name = "";
            ((Video)m3).Type = "";
            ((Video)m3).Display();
            ((Video)m3).Purchase();

        }
    }


    public class Movie : Media  
    { 
        public string Title { get; set; }
        //default constructor
        public Movie()
        {

        }
        public override string Display() // must use override to  modify ab class behavior
        {
            return "** displaying **";
        }
    }


    public class Show : Media // extend behavior of Media ab class - must override existing behavior
    {
        public string Year { get; set; }
        //default constructor
        public Show()
        {
            
        }
        
        public override double Purchase() // can't override method that doesn't allow override - see virtual below
        {
            return 5.99;
            //return base.Purchase(); base = base constructor - sometimes we want the base for certain functionality of base class
        }
        public override string Display() // must use override to  modify ab class behavior
        {
            return "** displaying **";
        }
    }

    public class Video : Media
    {
        public string Type { get; set; }
        //default constructor
        public Video()
        {

        }

        public override string Display() // must use override to  modify ab class behavior
        {
            return "** displaying **";
        }
    }

}
    public abstract class Media // can contain code. interface is only method calls - straight blueprint each class above has a name - implementing abstract Media.
                                // but each closs has diff unique properties 
    {
        //creating property
        public string Name { get; set; }

        public Media()
        {
            
        }
        // same behavior as interface - beautiful
        public abstract string Display(); //individual classes do there own thing with it

        public virtual double Purchase() // virtual - can optionall override it if you want
    {
        return 9999.99;
    }


    }


    //public interface IMedia { }



