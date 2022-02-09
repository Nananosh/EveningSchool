using AutoMapper;
using EveningSchool.Models;
using EveningSchool.ViewModels.Admin;
using EveningSchool.ViewModels.Schedule;

namespace EveningSchool.ViewModels.Mappings
{
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<ClassViewModel, Class>()
                .ForMember(dest => dest.Id,
                    opt => opt.MapFrom
                        (src => src.Id))
                .ForMember(dest => dest.ClassName,
                    opt => opt.MapFrom
                        (src => src.ClassName))
                .ForMember(dest => dest.Students,
                    opt => opt.Ignore())
                .ForMember(dest => dest.Lessons,
                    opt => opt.Ignore()).ReverseMap();

            CreateMap<SubjectViewModel, Subject>()
                .ForMember(dest => dest.Id,
                    opt => opt.MapFrom
                        (src => src.Id))
                .ForMember(dest => dest.SubjectName,
                    opt => opt.MapFrom
                        (src => src.SubjectName))
                .ForMember(dest => dest.Lessons,
                    opt => opt.Ignore()).ReverseMap();
            
            CreateMap<CabinetViewModel, Cabinet>()
                .ForMember(dest => dest.Id,
                    opt => opt.MapFrom
                        (src => src.Id))
                .ForMember(dest => dest.CabinetNumber,
                    opt => opt.MapFrom
                        (src => src.CabinetNumber))
                .ForMember(dest => dest.Lessons,
                    opt => opt.Ignore()).ReverseMap();

            CreateMap<StudentViewModel, Student>()
                .ForMember(dest => dest.Id,
                    opt => opt.MapFrom
                        (src => src.Id))
                .ForMember(dest => dest.ClassId,
                    opt => opt.MapFrom
                        (src => src.ClassId))
                .ForMember(dest => dest.Name,
                    opt => opt.MapFrom
                        (src => src.Name))
                .ForMember(dest => dest.Surname,
                    opt => opt.MapFrom
                        (src => src.Surname))
                .ForMember(dest => dest.Lastname,
                    opt => opt.MapFrom
                        (src => src.Lastname))
                .ForMember(dest => dest.Telephone,
                    opt => opt.MapFrom
                        (src => src.Telephone))
                .ForMember(dest => dest.Address,
                    opt => opt.MapFrom
                        (src => src.Address))
                .ForMember(dest => dest.Class,
                    opt => opt.MapFrom
                        (src => src.Class)).ReverseMap();

            CreateMap<TeacherViewModel, Teacher>()
                .ForMember(dest => dest.Id,
                    opt => opt.MapFrom
                        (src => src.Id))
                .ForMember(dest => dest.Name,
                    opt => opt.MapFrom
                        (src => src.Name))
                .ForMember(dest => dest.Surname,
                    opt => opt.MapFrom
                        (src => src.Surname))
                .ForMember(dest => dest.Lastname,
                    opt => opt.MapFrom
                        (src => src.Lastname))
                .ForMember(dest => dest.Telephone,
                    opt => opt.MapFrom
                        (src => src.Telephone))
                .ForMember(dest => dest.Category,
                    opt => opt.MapFrom
                        (src => src.Category))
                .ForMember(dest => dest.Lessons,
                    opt => opt.Ignore()).ReverseMap();

            CreateMap<LessonViewModel, Lesson>()
                .ForMember(dest => dest.Id,
                    opt => opt.MapFrom
                        (src => src.Id))
                .ForMember(dest => dest.ClassId,
                    opt => opt.MapFrom
                        (src => src.ClassId))
                .ForMember(dest => dest.SubjectId,
                    opt => opt.MapFrom
                        (src => src.SubjectId))
                .ForMember(dest => dest.TeacherId,
                    opt => opt.MapFrom
                        (src => src.TeacherId))
                .ForMember(dest => dest.CabinetId,
                    opt => opt.MapFrom
                        (src => src.CabinetId))
                .ForMember(dest => dest.DateStart,
                    opt => opt.MapFrom
                        (src => src.DateStart))
                .ForMember(dest => dest.DateEnd,
                    opt => opt.MapFrom
                        (src => src.DateEnd))
                .ForMember(dest => dest.LessonNumber,
                    opt => opt.MapFrom
                        (src => src.LessonNumber))
                .ForMember(dest => dest.RecurrenceRule,
                    opt => opt.MapFrom
                        (src => src.RecurrenceRule))
                .ForMember(dest => dest.Replacement,
                    opt => opt.MapFrom
                        (src => src.Replacement)).ReverseMap();
            CreateMap<ArticleViewModel, Article>().ReverseMap();
        }
    }
}