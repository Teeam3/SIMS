using Core.Entities;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;

namespace SIMS.DTOs
{
    public class StudentDto : Person
    {
        public string Class {  get; set; }
        public List<ScoreDto> Scores { get; set; }
    }
}
