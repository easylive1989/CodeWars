using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    public class SimpleRun
    {
        internal class Person
        {
            public double position;
            public double speed;
        }

        public int RunnersMeetings(int[] StartPosition, int[] speed)
        {
            List<Person> people = InitPeopleList(StartPosition, speed);
            int maxMeetPeople = -1;
            while (HasNextMeetting(people))
            {
                ToNextSecond(people);
                if (HasMeeting(people))
                {
                    int curMeetPeople = CalculateMeetPeople(people);
                    maxMeetPeople = curMeetPeople > maxMeetPeople ? curMeetPeople : maxMeetPeople;
                }

            }
            return maxMeetPeople;
        }

        private bool HasMeeting(List<Person> people)
        {
            return people.GroupBy(i => i.position).Count() != people.Count();
        }

        private int CalculateMeetPeople(List<Person> people)
        {
            return people.GroupBy(i => i.position).Max(i => i.Count());
        }

        private void ToNextSecond(List<Person> people)
        {
            foreach (var person in people)
            {
                person.position = Math.Round(person.position + person.speed / 60 ,2);
            }
        }

        private List<Person> InitPeopleList(int[] StartPosition, int[] speed)
        {
            var people = new List<Person>();
            for (int idx = 0; idx < StartPosition.Length; idx++)
            {
                people.Add(new Person()
                {
                    position = StartPosition[idx],
                    speed = speed[idx]
                });
            }
            return people;
        }

        private bool HasNextMeetting(List<Person> people)
        {
            var sortByPosition = people.OrderBy(i => i.position).ToList();
            var sortBySpeed = people.OrderBy(i => i.speed).ToList();

            return !sortByPosition.SequenceEqual(sortBySpeed);
        }
    }
}