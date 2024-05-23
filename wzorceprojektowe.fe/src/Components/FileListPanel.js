import React, { useState, useEffect } from "react";
import "../Styles/FileListPanel.css";
import Tabs from "@mui/material/Tabs";
import Tab from "@mui/material/Tab";
import { styled } from "@mui/material/styles";

export default function FileListPanel({ files, onFileSelect, toInterpret }) {
  const [value, setValue] = useState(0);
  const [splittedInterpret, setSplittedInterpret] = useState(null);

  useEffect(() => {
    if (toInterpret !== null) {
      setSplittedInterpret(toInterpret.split(" "));
    }
  }, [toInterpret]);

  const handleTabChange = (event, newValue) => {
    setValue(newValue);
    onFileSelect(newValue);
  };

  const StyledTab = styled((props) => <Tab disableRipple {...props} />)(
    ({ theme }) => ({
      textTransform: "none",
      fontWeight: theme.typography.fontWeightRegular,
      fontSize: theme.typography.pxToRem(15),
      marginRight: theme.spacing(1),
      color: "rgba(255, 255, 255, 0.7)",
      "&.Mui-selected": {
        color: "#fff",
      },
      "&.Mui-focusVisible": {
        backgroundColor: "rgba(100, 95, 228, 0.32)",
      },
    })
  );
  const StyledTabs = styled((props) => (
    <Tabs
      {...props}
      TabIndicatorProps={{
        children: <span className="MuiTabs-indicatorSpan" />,
      }}
    />
  ))({
    "& .MuiTabs-indicator": {
      display: "flex",
      justifyContent: "center",
      backgroundColor: "transparent",
    },
    "& .MuiTabs-indicatorSpan": {
      width: "100%",
      backgroundColor: "#76ABAE",
    },
  });

  const replaceTags = (fileName) => {
    let replacedFileName = fileName;
    if (splittedInterpret !== null && fileName) {
      splittedInterpret.forEach((item) => {
        const tag = item.split("#");
        if (fileName.includes("#" + tag[1] + "#")) {
          replacedFileName = replacedFileName.replaceAll("#" + tag[1] + "#", tag[2]);
        }
      });
    }
    return replacedFileName;
  };

  return (
    <div className="fileListPanel">
      <StyledTabs
        value={value}
        variant="scrollable"
        scrollButtons
        onChange={handleTabChange}
        
      >
        {files !== null
          ? files.map((file, index) => (
              <StyledTab key={index} label={replaceTags(file.fileName)} />
            ))
          : null}
      </StyledTabs>
    </div>
  );
}
