using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningEncapsulationGetSet
{
    public class Farmer
    {
        public int BagsOfFeed { get; private set; } //now we can change it value only here.
        private int feedMultiplier;
        public int FeedMultiplier { get { return feedMultiplier; } }
        private int numberOfCows;
        public int NumberOfCows
        {
            get //whenever numberOfCows will be read, it will get value from here.
            {
                return numberOfCows;
            }
            set
            {
                numberOfCows = value; //whenever NumberOfCows will bet set it will change numberOfCows value, then it will update BagsOfFeed value, cool!
                BagsOfFeed = FeedMultiplier * numberOfCows;
            }
        }
        public Farmer(int numberOfCows, int feedMultiplier)
        {
            this.feedMultiplier = feedMultiplier; NumberOfCows = numberOfCows;
        }
    } 
}
