using GolBet.Entities.Enums;
using GolBet.Services.DTOs;

namespace GolBet.Services.Interfaces;

public interface IMatchService
{
    /// <summary>Match board: all active matches ordered by date.</summary>
    Task<IEnumerable<MatchDto>> GetBoardAsync(MatchStatus? status = null, string? search = null);

    Task<MatchDetailDto?> GetDetailAsync(int id);

    Task<MatchFormDto?> GetForEditAsync(int id);
    Task CreateAsync(MatchFormDto dto);
    Task UpdateAsync(MatchFormDto dto);
    Task DeactivateAsync(int id);

    // GolBet.Services/Interfaces/IMatchService.cs  (agregar)
    Task StartMatchAsync(int id);
    Task<ResolutionSummaryDto> CloseMatchAsync(MatchResultFormDto dto);


}
