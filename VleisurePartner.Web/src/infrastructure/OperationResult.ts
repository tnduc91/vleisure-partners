export default interface OperationResult<T>{
    successData: T;
    isSuccessful : boolean;
    errorMessages: string[];
    status: number;
}