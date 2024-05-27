namespace QLHSC07.Model.BaseModels
{
    public class EntityDto<T> : IEntityDto<T>
    {
        public T Id { get; set; }
    }
}
