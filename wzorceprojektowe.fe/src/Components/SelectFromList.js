import * as React from 'react';
import InputLabel from '@mui/material/InputLabel';
import MenuItem from '@mui/material/MenuItem';
import FormControl from '@mui/material/FormControl';
import Select from '@mui/material/Select';
import TextField from '@mui/material/TextField';

export default function SelectFromList({handleCustomInputChange, index, hashName, name, methodIndex = null}) {
  const [showCustomInput, setShowCustomInput] = React.useState(false);
  const [selectedValue, setSelectedValue] = React.useState("int");
  const [customValue, setCustomValue] = React.useState('');


  const handleChange = (event) => {
    const selectedValue = event.target.value;
    setSelectedValue(selectedValue);
    if (selectedValue === "Myown") {
      setShowCustomInput(true);
    } else {
      handleCustomInputChange(index, selectedValue, hashName, name, methodIndex)
      setShowCustomInput(false);
      setCustomValue('');
    }
  };


  return (
    <div>
      <FormControl sx={{ m: 1, minWidth: 80 }}>
        <InputLabel id="demo-simple-select-autowidth-label" style={{ color: '#76ABAE', fontSize: 14, fontWeight: 'bold' }}>Type</InputLabel>
        {showCustomInput ? (
          <TextField
            id="custom-input"
            label=""
            variant="outlined"
            onChange={(text) => handleCustomInputChange(index, text.target.value, hashName, name, methodIndex)}
            style={{ color: '#76ABAE', backgroundColor: '#333', fontSize: 16, maxWidth:100, minWidth:100 }}
            inputProps={{ style: { color: "#76ABAE" } }}
          />
        ) : (
          <Select
            labelId="demo-simple-select-autowidth-label"
            id="demo-simple-select-autowidth"
            value={selectedValue}
            onChange={handleChange}
            autoWidth
            label="Type"
            style={{ color: '#76ABAE', backgroundColor: '#333', fontSize: 16, maxWidth:100, minWidth:100 }}
          >
            <MenuItem value={"int"}>int</MenuItem>
            <MenuItem value={"double"}>double</MenuItem>
            <MenuItem value={"string"}>string</MenuItem>
            <MenuItem value={"char"}>char</MenuItem>
            <MenuItem value={"bool"}>bool</MenuItem>
            <MenuItem value={"Myown"}>My own</MenuItem>
          </Select>
        )}
      </FormControl>
    </div>
  );
}
