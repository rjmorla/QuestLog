using api.Dtos.Quest;
using api.Models;

namespace api.Mappers
{
    public static class QuestMappers
    {
        public static QuestDto ToQuestDto(this Quest questModel) 
        {
            return new QuestDto
            {
                Id = questModel.Id,
                Title = questModel.Title,
                Description = questModel.Description,
                CreatedOn = questModel.CreatedOn
            };
        }

        public static Quest ToQuestFromCreateDTO(this CreateQuestRequestDto questDto)
        {
            return new Quest
            {
                Title = questDto.Title,
                Description = questDto.Description
            };
        }
    }
}