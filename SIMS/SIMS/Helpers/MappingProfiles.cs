using AutoMapper;
using Core.Entities;
using SIMS.DTOs;
namespace SIMS.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Class, ClassDto>()
                .ForMember(classDto => classDto.Facuties, ex => ex.MapFrom(cls => cls.Faculties.Select(f => f.Name)))
                .ForMember(classDto => classDto.Students, ex => ex.MapFrom(cls => cls.Students.Select(f => f.Name)))
                .ForMember(classDto => classDto.Curriculum, ex => ex.MapFrom(cls => cls.Curriculum.Professor));

            CreateMap<Student,StudentDto>()
                .ForMember(studentDto => studentDto.Class, ex => ex.MapFrom(student => student.Class.Name));

            CreateMap<Score, ScoreDto>()
                .ForMember(scoreDto => scoreDto.Course, ex => ex.MapFrom(score => score.Course.Name))
                .ForMember(scoreDto => scoreDto.Score, ex => ex.MapFrom(score => score.Point));

            CreateMap<Faculty, FacultyDto>()
                .ForMember(facultyDto => facultyDto.ClassList, ex => ex.MapFrom(faculty => faculty.Classes.Select(f => f.Name)));

            CreateMap<Course, CourseDto>()
                .ForMember(courseDto => courseDto.Classes, ex => ex.MapFrom(course => course.Classes.Select(course => course.Name)))
                .ForMember(courseDto => courseDto.Faculties, ex => ex.MapFrom(course => course.Faculties.Select(faculty => faculty.Name)));

            CreateMap<Curriculum, CurriculumDto>()
                .ForMember(curriculumDto => curriculumDto.Students, ex => ex.MapFrom(curriculum => curriculum.Students.Select(student => student.Name)))
                .ForMember(curriculumDto => curriculumDto.Courses, ex => ex.MapFrom(curriculum => curriculum.Courses.Select(course => course.Name)));
        }
    }
}
