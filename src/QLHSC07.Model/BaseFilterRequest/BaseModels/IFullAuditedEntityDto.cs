namespace QLHSC07.Model.BaseModels
{
    public interface IFullAuditedEntityDto<T>: IEntityDto<T>, IAuditedEntityDto
    {
    }
}
