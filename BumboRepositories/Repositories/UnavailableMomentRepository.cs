﻿using BumboData;
using BumboData.Enums;
using BumboData.Interfaces.Repositories;
using BumboData.Models;
using BumboRepositories.Utils;
using Microsoft.EntityFrameworkCore;

namespace BumboRepositories.Repositories
{
    public class UnavailableMomentRepository : Repository<UnavailableMoment>, IUnavailableMomentsRepository
    {
        public UnavailableMomentRepository(BumboContext context) : base(context)
        {
        }

        public IEnumerable<UnavailableMoment> GetAll(string employeeId)
        {
            return DbSet.Where(e => e.Employee.Id == employeeId).ToList();
        }
        public IEnumerable<UnavailableMoment> GetOverlappingMoments(UnavailableMoment unavailableMoment)
        {
            return DbSet.Where(u => unavailableMoment.Employee.Id == u.Employee.Id)
                .Where(e => (unavailableMoment.StartTime < e.EndTime &&
                            e.StartTime < unavailableMoment.EndTime)).ToList();
        }

        public bool IsEmployeeAvailable(string employeeId, DateTime startTime, DateTime endTime)
        {
            // check if employee is unavailable in unavailable moments 
            var unavailableMoments = DbSet.Where(u => u.Employee.Id == employeeId && u.StartTime.Date == startTime.Date)
                .ToList();
            return !unavailableMoments.Any(moment => startTime < moment.EndTime &&
                                                    moment.StartTime < endTime);
        }

        /*
         * Returns if the employee has any school planned given week.
         */
        public bool EmployeeSchoolWeek(string employee, int year, int week)
        {
            // Tolist is required, weeknumber function can't be converted to SQL.
            return DbSet.ToList().Any(s =>
                s.EmployeeId == employee && s.StartTime.Year == year && s.StartTime.GetWeekNumber() == week &&
                s.Type == UnavailableMomentType.School);
        }

        public List<UnavailableMoment> GetSchoolUnavailableMomentsByWeek(string employee, int year, int week)
        {
            // Tolist is required, weeknumber function can't be converted to SQL.
            return DbSet.ToList().Where(s =>
                s.EmployeeId == employee && s.StartTime.Year == year && s.StartTime.GetWeekNumber() == week &&
                s.Type == UnavailableMomentType.School).ToList();
        }

        public List<UnavailableMoment> GetUnavailableMomentsByDay(string employee, DateOnly day)
        {
            return DbSet.Where(s => s.EmployeeId == employee && s.StartTime.Date.DayOfYear == day.DayOfYear
                                                             && s.StartTime.Date.Year == day.Year).ToList();
        }

        // returns next full week of unavailable moments.
        public List<UnavailableMoment> GetWeekOfUnavailableMomentsAfterDateForEmployee(DateTime date, string employeeId)
        {
            return DbSet.Where(u => u.Employee.Id == employeeId && u.StartTime.Date >= date && u.StartTime <= date.AddDays(8)).ToList();

        }

        public IEnumerable<UnavailableMoment> GetAllUnavailabilityMomentsByReviewStatus(int branchId, ReviewStatus status, string search)
        {
            if (search == null)
            {
                return DbSet.Where(u => u.Employee.DefaultBranchId == branchId && u.ReviewStatus == status).Include(u => u.Employee).ToList();
            }
            return DbSet.Where(u => u.Employee.DefaultBranchId == branchId && u.ReviewStatus == status && (u.Employee.FirstName + " " + u.Employee.LastName).Trim().Contains(search.Trim())).Include(u => u.Employee).ToList();
        }

        public IEnumerable<UnavailableMoment> GetAllMomentsFromMonth(int branchId, DateTime date, string search)
        {
            if (search == null)
            {
                return DbSet.Where(u => u.StartTime.Month <= date.Month && u.EndTime >= date && u.StartTime.Year == date.Year && u.Employee.DefaultBranchId == branchId).Include(u => u.Employee).ToList();
            }
            return DbSet.Where(u => u.StartTime.Month <= date.Month && u.EndTime >= date && u.StartTime.Year == date.Year && u.Employee.DefaultBranchId == branchId && (u.Employee.FirstName + " " + u.Employee.LastName).Trim().Contains(search.Trim())).Include(u => u.Employee).ToList();
        }

        public void UpdateRange(ReviewStatus newStatus, List<int> momentIds)
        {
            // updates a list of unavailable moments to a new status.
            List<UnavailableMoment> trackedMoments = new List<UnavailableMoment>();
            foreach (var id in momentIds)
            {
                var moment = Get(id);
                // potentially throw exception here if it is null? Or continue with rest of list? Even if this situation is incredibly rare.
                if (moment != null)
                {

                    if (moment.ReviewStatus == ReviewStatus.Pending)
                    {
                        moment.ReviewStatus = newStatus;
                        trackedMoments.Add(moment);
                    }
                }
            }
            DbSet.UpdateRange(trackedMoments);
            Context.SaveChanges();
        }
    }
}