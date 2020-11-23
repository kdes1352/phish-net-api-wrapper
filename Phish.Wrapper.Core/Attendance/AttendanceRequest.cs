namespace Phish.Wrapper.Core.Attendance
{
    using System;
    using System.Threading.Tasks;
    using Models;
    using Models.Attendance;

    public class AttendanceRequest : RequestBase<Attendance>
    {
        public AttendanceRequest(ProjectSettings settings) : base(settings)
        {
            Settings = settings;
            SectionName = "attendance";
        }

        public async Task<Base<Attendance>> GetAttendance()
        {
            return await MakeRequest(Constants.MethodNames.Get);
        }

        public async Task<Base<Attendance>> GetAttendance(int showid)
        {
            AddParameter(nameof(showid), showid);
            return await MakeRequest(Constants.MethodNames.Get);
        }

        public async Task<Base<Attendance>> GetAttendance(string showdate)
        {
            AddParameter(nameof(showdate), showdate);
            return await MakeRequest(Constants.MethodNames.Get);
        }

        public async Task<Base<Attendance>> AddAttendance()
        {
            //TODO: Must do a post, requires authkey
            throw new NotImplementedException();
        }

        public async Task<Base<Attendance>> RemoveAttendance()
        {
            //TODO must do a post, requires authkey
            throw new NotImplementedException();
        }
    }
}