namespace Phish.Wrapper.Core.Attendance
{
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
            return await MakeRequest("get");
        }

        public async Task<Base<Attendance>> GetAttendance(int showid)
        {
            Parameters.Add($"showid={showid}");
            return await MakeRequest("get");
        }

        public async Task<Base<Attendance>> GetAttendance(string showdate)
        {
            Parameters.Add($"showdate={showdate}");
            return await MakeRequest("get");
        }
    }
}