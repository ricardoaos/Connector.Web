using System;
using Tnf.Dto;

namespace Connector.Dto
{
    public interface IDefaultRequestDto : IRequestDto
    {
        Guid Id { get; set; }
    }
}
