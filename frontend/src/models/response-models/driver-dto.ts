import { CarMetaDto } from "./car-meta-dto";

export interface DriverDto {
  id: number;
  username: string;
  phoneNumber: string;
  car: CarMetaDto;
}
