import { Injectable } from '@angular/core';
 import { ApiResponse } from '../models/api-response.model';
import { SecUser } from '../models/SecUser';
import { LoginPayload } from '../models/LoginPayload';
import { DriverPayload } from '../models/drivers';
import { Observable } from 'rxjs/internal/Observable';
import { HttpClient } from '@angular/common/http';
 import { ImportsModule } from '../imports';
import { AppConstants } from './shared/Constants';
import { ApprovalPayload } from '../models/ApprovalPayload';
import { TrucksPayload } from '../models/TrucksPayload';
import { TruckType } from '../models/TruckTypes';
import { JobRequest } from '../models/jobRequest';
import { JobRequestPayload, RequestWithPrice } from '../models/jobRequestPayload';
import { Customer } from '../models/customer';
import { PriceAgreement } from '../models/priceAgreement';
import { Truck } from '../models/Truck';


@Injectable({
  providedIn: 'root'
})
export class DataService {
  postCustomer<T>(endpoint: string, customerRegData: Customer): Observable<T>{
 return this.http.post<T>(`${this.baseUrl}Customer/${endpoint}`,customerRegData);
  }

    //private baseUrl = 'http://softmaxafrica-001-site5.gtempurl.com/'; 
    private baseUrl = AppConstants.API_BASE_URL; 

    constructor(private http: HttpClient) {}

    
  postDriverFormData(endpoint: string, formData: FormData): Observable<any> {
    return this.http.post(`${this.baseUrl}Driver/${endpoint}`, formData, {
  
    });
  }
  
  fetchRequestById(jobId: string | null): Observable<ApiResponse<JobRequest[]>> {
    return this.http.get<ApiResponse<JobRequest[]>>(
      `${this.baseUrl}JobRequest/GetJobRequestById/${jobId}`
    );
  }

   
  getAvailableTrucks(type: string, companyId: string): Observable<ApiResponse<Truck[]>> {
    return this.http.get<ApiResponse<Truck[]>>(
      `${this.baseUrl}Truck/GetAvailableTrucksByTruckType/${type}/${companyId}`
    );
  }
  

  getCustomers(): Observable<ApiResponse<Customer[]>> {
    return this.http.get<ApiResponse<Customer[]>>(
      `${this.baseUrl}Customer/GetAllCustomers/`
    );
  }
  GetCustomersByCompany(companyId: string): Observable<ApiResponse<Customer[]>> {
    return this.http.get<ApiResponse<Customer[]>>(
      `${this.baseUrl}Customer/GetCustomersByCompany/${companyId}`
    );
  }
 

  
  updateJobRequest( requestUpdates: RequestWithPrice  ) {
  return this.http.put<void>(`${this.baseUrl}JobRequest/UpdateJobRequest/${requestUpdates.jobRequestID}`, requestUpdates);
}
  createJobRequest<T>(endpoint: string, payload: JobRequestPayload): Observable<T> {
    return this.http.post<T>(`${this.baseUrl}JobRequest/${endpoint}`, payload);
  }
  //private baseUrl = 'http://softmaxafrica-001-site5.gtempurl.com/'; 
     getCompanyJobs(companyId: string): Observable<ApiResponse<JobRequest[]>> {
      return this.http.get<ApiResponse<JobRequest[]>>(
        `${this.baseUrl}JobRequest/GetCompanyJobRequest/${companyId}`
      );
    }
  
 
 
  
  GetTruckTypes(): Observable<ApiResponse<TruckType[]>> {
    return this.http.get<ApiResponse<TruckType[]>>(
      `${this.baseUrl}Company/GetAllTruckTypes`
    );
  }
  
   



  post<T>(endpoint: string, payload: T): Observable<T> {
    return this.http.post<T>(`${AppConstants.API_BASE_URL}Company/${endpoint}`, payload);
  }

 
  postDriver<T>(endpoint: string, payload: DriverPayload): Observable<T> {
    return this.http.post<T>(`${this.baseUrl}Driver/${endpoint}`, payload);
  }
 
  postTruck<T>(endpoint: string, payload: TrucksPayload): Observable<T> {
    return this.http.post<T>(`${this.baseUrl}Truck/${endpoint}`, payload);
  }
 

  login(endpoint: string,payload: LoginPayload): Observable<ApiResponse<SecUser>> {
    return this.http.post<ApiResponse<SecUser>>(`${this.baseUrl}SecUser/${endpoint}`, payload);
  }
  
  getCompanyDrivers(companyId: string): Observable<ApiResponse<DriverPayload[]>> {
    return this.http.get<ApiResponse<DriverPayload[]>>(
      `${this.baseUrl}Driver/GetCompanyDrivers/${companyId}`
    );
  }
  getAvilableCompanyDrivers(companyId: string): Observable<ApiResponse<DriverPayload[]>> {
    return this.http.get<ApiResponse<DriverPayload[]>>(
      `${this.baseUrl}Driver/GetAvilableCompanyDrivers/${companyId}`
    );
  }
  
  GetTruckByCompanyId(companyId: string): Observable<ApiResponse<TrucksPayload[]>> {
    return this.http.get<ApiResponse<TrucksPayload[]>>(`${this.baseUrl}Truck/GetTruckByCompanyId/${companyId}`);
  }
  //#region driver Vetting
  
  getDriversAwaitingApproval(companyId: string): Observable<ApiResponse<DriverPayload[]>> {
    return this.http.get<ApiResponse<DriverPayload[]>>(
      `${this.baseUrl}Company/GetDriversAwaitingApprovalByCompanyId/${companyId}`
    );
  }
 
  approveDriver(approvalPayload: ApprovalPayload): Observable<ApiResponse<DriverPayload>> {
    return this.http.post<ApiResponse<DriverPayload>>(
      `${this.baseUrl}Company/ApproveDriver`,
      approvalPayload
    );
  }
//  #endregion
updateDriver(driver: DriverPayload): Observable<void> {
  return this.http.put<void>(`${this.baseUrl}Driver/UpdateDriver/${driver.driverID}`, driver);
}

updateTruckDetails(updatedTruck: TrucksPayload) {
  return this.http.put<void>(`${this.baseUrl}Truck/UpdateTruckByTruckId/${updatedTruck.truckID}`, updatedTruck);
}

deleteDriver(driverId: string): Observable<void> {
  return this.http.delete<void>(`${this.baseUrl}Driver/DeleteDriver/${driverId}`);
}

}
