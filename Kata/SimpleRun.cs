using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    // https://www.codewars.com/kata/5889a0706069af1cb9000176
    // 5 kyu
    public class SimpleRun
    {
        private class Person
        {
            public double Position;
            public double Speed;
        }

        public int RunnersMeetings(int[] startPosition, int[] speed)
        {
            List<Person> people = InitPeopleList(startPosition, speed);
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
            return people.GroupBy(i => i.Position).Count() != people.Count();
        }

        private int CalculateMeetPeople(List<Person> people)
        {
            return people.GroupBy(i => i.Position).Max(i => i.Count());
        }

        private void ToNextSecond(List<Person> people)
        {
            foreach (var person in people)
            {
                person.Position = Math.Round(person.Position + person.Speed / 60 ,2);
            }
        }

        private List<Person> InitPeopleList(int[] startPosition, int[] speed)
        {
            var people = new List<Person>();
            for (int idx = 0; idx < startPosition.Length; idx++)
            {
                people.Add(new Person()
                {
                    Position = startPosition[idx],
                    Speed = speed[idx]
                });
            }
            return people;
        }

        private bool HasNextMeetting(List<Person> people)
        {
            var sortByPosition = people.OrderBy(i => i.Position).ToList();
            var sortBySpeed = people.OrderBy(i => i.Speed).ToList();

            return !sortByPosition.SequenceEqual(sortBySpeed);
        }
    }
}