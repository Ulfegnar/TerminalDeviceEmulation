namespace TestUU.Commands
{
    public interface ICheckDevice: IComand
    {
        byte[] Signature { get; }
        byte TypeComand { get; }
        /// <summary>
        /// если 0xFF - отправка всем абонентам
        /// </summary>
        byte AbonentNumber { get; }
    }
}