namespace ValidationLibrary
{
    public class ValidationHelper
    {
        /// <summary>
        /// Validate entity against validation rules
        /// </summary>
        /// <typeparam name="T">Type of class</typeparam>
        /// <param name="entity">Instance of class to validate</param>
        /// <returns></returns>
        public static EntityValidationResult ValidateEntity<T>(T entity) where T : class
        {
            return (new EntityValidator<T>()).Validate(entity);
        }
    }
}