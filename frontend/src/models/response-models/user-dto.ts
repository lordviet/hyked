import { CarMetaDto } from "./car-meta-dto";

export interface UserDto {
  id: number;
  username: string;
  apiKey: string;
  car: CarMetaDto;
}
