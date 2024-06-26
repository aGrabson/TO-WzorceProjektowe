import PatternService from "../Services/PatternService";

export const GetPatternById = async (data) => {
  const response = await PatternService.GetPatternById(data);
  if (response === undefined) {
    return null;
  }
  if (response.status === 200) {
    return response.data;
  } else if (response.status === 400) {
    return null;
  }
};
export const GetPatternsByType = async (data) => {
    const response = await PatternService.GetPatternsByType(data);
    if (response === undefined) {
      return null;
    }
    if (response.status === 200) {
      return response.data;
    } else if (response.status === 400) {
      return null;
    }
  };
  export const GetPatternCodeById = async (data) => {
    const response = await PatternService.GetPatternCodeById(data);
    if (response === undefined) {
      return null;
    }
    if (response.status === 200) {
      return response.data;
    } else if (response.status === 400) {
      return null;
    }
  };
  export const GetPatternCodeByName = async (data) => {
    const response = await PatternService.GetPatternCodeByName(data);
    if (response === undefined) {
      return null;
    }
    if (response.status === 200) {
      return response.data;
    } else if (response.status === 400 || response.status === 404) {
      alert("To be continued...")
      return null;
    }
  };
  export const DownloadCode = async (data) => {
    const response = await PatternService.DownloadCode(data);
    if (response === undefined) {
      return null;
    }
    if (response.status === 200) {
      return response.data;
    } else if (response.status === 400) {
      alert("Error occured while downloading file.");
      return null;
    }
  };