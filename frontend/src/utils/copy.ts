import toast from "react-hot-toast";
import copy from "copy-to-clipboard";

export const copyContent = async (
  content: string,
  successMsg: string,
  errorMsg: string
) => {
  try {
    copy(content);
    toast.success(successMsg);
  } catch (error) {
    toast.error(errorMsg);
  }
};
