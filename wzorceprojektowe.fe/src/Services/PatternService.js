import { backendHostname } from "../Hostname/BackendHostname";
import axios from "axios";

export default class PatternService {
  static async GetPatternById(data) {
    try {
      const response = await axios.get(
        backendHostname + "Pattern/GetPatternById/" + data
      );
      return response;
    } catch (error) {
      return error.response;
    }
  }
  static async GetPatternsByType(data) {
    try {
      const response = await axios.post(
        backendHostname + "Pattern/GetPatternsByType",
        {
          Type: data.type,
        }
      );
      return response;
    } catch (error) {
      return error.response;
    }
  }
  static async GetPatternCodeById(data) {
    try {
      const response = await axios.post(
        backendHostname + "Pattern/GetPatternCodeByType",
        {
          patternID: data.patternID,
          toInterpret: data.toInterpret,
        }
      );
      return response;
    } catch (error) {
      return error.response;
    }
  }
  static async GetPatternCodeByName(data) {
    try {
      const response = await axios.post(
        backendHostname + "Pattern/GetPatternCodeByName",
        {
          patternName: data.patternName,
        }
      );
      return response;
    } catch (error) {
      return error.response;
    }
  }
}
