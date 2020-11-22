namespace Infrastructure.Models
{
    public static class DataPermissions
    {
        public const string RolesManagment = nameof(RolesManagment);

        #region clients
        public const string ClientGet = nameof(ClientGet);
        public const string ClientInsert = nameof(ClientInsert);
        public const string ClientUpdate = nameof(ClientUpdate);
        public const string ClientDelete = nameof(ClientDelete);
        #endregion clients

        #region users
        public const string UserGet = nameof(UserGet);
        public const string UserInsert = nameof(UserInsert);
        public const string UserUpdate = nameof(UserUpdate);
        public const string UserDelete = nameof(UserDelete);
        #endregion users

        #region services
        public const string ServiceGet = nameof(ServiceGet);
        public const string ServiceInsert = nameof(ServiceInsert);
        public const string ServiceUpdate = nameof(ServiceUpdate);
        public const string ServiceDelete = nameof(ServiceDelete);
        #endregion services

        #region requests
        public const string RequestGet = nameof(RequestGet);
        public const string RequestInsert = nameof(RequestInsert);
        public const string RequestUpdate = nameof(RequestUpdate);
        public const string RequestDelete = nameof(RequestDelete);
        #endregion requests

        #region request types
        public const string RequestTypeGet = nameof(RequestTypeGet);
        public const string RequestTypeInsert = nameof(RequestTypeInsert);
        public const string RequestTypeUpdate = nameof(RequestTypeUpdate);
        public const string RequestTypeDelete = nameof(RequestTypeDelete);
        #endregion request types

        #region positions
        public const string PositionGet = nameof(PositionGet);
        public const string PositionInsert = nameof(PositionInsert);
        public const string PositionUpdate = nameof(PositionUpdate);
        public const string PositionDelete = nameof(PositionDelete);
        #endregion positions
    }
}
