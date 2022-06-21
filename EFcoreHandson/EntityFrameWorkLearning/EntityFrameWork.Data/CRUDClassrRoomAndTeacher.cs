using EntityFramework.Data.Entities;
using EntityFrameWork.Data;

namespace EntityFramework.Data
{
    public class CRUDClassRoomAndTeacher
    {
        DemoDbContext demoDbContext = new DemoDbContext();

        public void InsertTeacher(Teacher teacher)
        {
            demoDbContext.Teachers.Add(teacher);
            demoDbContext.SaveChanges();
        }

        public void InsertClassRoom(ClassRoom classRoom)
        {
            demoDbContext.ClassRooms.Add(classRoom);
            demoDbContext.SaveChanges();
        }

        public void InsertClassRoomAndTeacher(ClassRoom classRoom, Teacher teacher)
        {
            classRoom.Teacher = teacher;
            demoDbContext.ClassRooms.Add(classRoom);
            demoDbContext.SaveChanges();
        }
    }
}