﻿using System.ComponentModel.DataAnnotations;

namespace Bumbo.Models.RosterManager
{
    public class OverviewItem
    {
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public double PrognosisHours { get; set; }
        public double RosteredHours { get; set; }
        public bool IsToday { get; set; }


        public bool ItemIsToday(DateTime date)
        {
            if (date == DateTime.Now)
            {
                return true;
            }
            return false;
        }


        // if the rostered hours are more than the prognosis hours, return true.
        public bool IsSufficientlyRostered()
        {
            if (RosteredHours >= PrognosisHours && RosteredHours > 0)
            {
                return true;
            }
            return false;
        }

        // if there are rostered hours, but it is not enough we return true
        public bool IsInsufficientlyRostered()
        {
            if (RosteredHours <= PrognosisHours && RosteredHours > 0)
            {
                return true;
            }
            return false;
        }

    }
}
