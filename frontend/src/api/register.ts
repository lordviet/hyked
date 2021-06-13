import axios from "axios";
import { BaseUri } from "../shared/constants";

export const Register = (
  username: string,
  password: string,
  phoneNumber: string
) => {
  axios({
    method: "post",
    url: `${BaseUri}/api/users/register`,
    data: {
      username,
      password,
      phoneNumber,
    },
  });
};
