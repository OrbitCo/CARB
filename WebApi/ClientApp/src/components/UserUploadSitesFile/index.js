// @flow

import React from 'react';
import { Link } from '@reach/router';
import { Upload } from '@progress/kendo-upload-react-wrapper';
import '@progress/kendo-ui';
// components
import UserPage from 'components/User/UserPage';
// styled components
import { Heading1, FormButton, Prompt } from 'components/User/StyledComponents';
// services
import { importMonitor } from 'services/webService';
// routes
import { basepath } from 'routes.js';

// --- components ---
type Props = {};

type State = {
  dataRows: Array<Object>,
  siteIds: Array<string>,
  monitorIds: Array<string>,
  submitStatus: 'pending' | 'success' | 'failure',
};

class UserUploadSitesFile extends React.Component<Props, State> {
  state: State = {
    dataRows: [],
    siteIds: [],
    monitorIs: [],
    submitStatus: 'pending',
  };

  onSelect = (ev) => {
    const reader = new FileReader();

    ev.files.forEach((file) => {
      reader.readAsText(file.rawFile);
    });

    reader.onload = () => {
      if (!reader.result) return;

      const rows = reader.result.split('\n');
      // remove header row
      const headerRow = rows.shift();
      const colNames = headerRow.split(',');
      // remove last (empty row)
      rows.pop();

      // build up data rows
      let dataRows = [];
      rows.forEach((row) => {
        const rowData = row.split(',');
        // build up stringified object with row data
        let rowString = '{ ';
        rowData.forEach((data, index) => {
          rowString += `"${colNames[index]}":"${rowData[index]}", `;
        });
        rowString = rowString.replace(/,\s*$/, '').replace(/'/g, '');
        rowString += ' }';
        rowString = rowString.replace(/\n|\r/g, '');
        dataRows.push(JSON.parse(rowString));
      });

      this.setState({ dataRows });
    };
  };

  onRemove = (ev) => {
    this.setState({ dataRows: [] });
  };

  handleSubmit = (ev) => {
    ev.preventDefault();

    if (this.state.dataRows.length === 0) {
      this.setState({ submitStatus: 'failure', siteIds: [], monitorIds: [] });
      return;
    }

    // build up unique siteIds and monitorIds from each row of submitted file
    const siteIds = [];
    const monitorIds = [];
    this.state.dataRows.forEach((row) => {
      const transactionType = row['Transaction Type'];
      if (transactionType === 'CS' || transactionType === 'AS') {
        const siteId = row['Site ID'];
        if (siteIds.indexOf(siteId) === -1) siteIds.push(siteId);
      }
      if (transactionType === 'CS' || transactionType === 'AM') {
        const monitorId = row['Monitor ID'];
        if (monitorIds.indexOf(monitorId) === -1) monitorIds.push(monitorId);
      }
    });

    importMonitor(this.state.dataRows).then(
      (res) => {
        this.setState({ submitStatus: 'success', siteIds, monitorIds });
      },
      (err) => {
        this.setState({ submitStatus: 'failure', siteIds: [], monitorIds: [] });
        console.error(err);
      },
    );
  };

  render() {
    const { dataRows, siteIds, monitorIds, submitStatus } = this.state;

    return (
      <UserPage>
        <div className="container">
          <Heading1>Upload Sites File</Heading1>

          <p>
            This is placeholder for the introductory text. Here we’ll explain
            that the user can upload a CSV file with each new line containing a
            different transaction type, and the data for that transaction type.
            Here we’ll also link to instructions for preparing a data file.
          </p>

          <Upload
            async={{ autoUpload: false }}
            validation={{ allowedExtensions: ['.csv'], multiple: 'false' }}
            select={this.onSelect}
            remove={this.onRemove}
          />

          <FormButton
            primary
            style={{ marginBottom: '1.25rem' }}
            onClick={this.handleSubmit}
            disabled={dataRows.length === 0}
          >
            Submit Data
          </FormButton>

          {submitStatus === 'success' && (
            <Prompt success className="alert alert-success" role="alert">
              {siteIds && siteIds.length === 1 && (
                <p>1 site was successfully submitted.</p>
              )}

              {siteIds && siteIds.length > 1 && (
                <p>{siteIds.length} sites were successfully submitted.</p>
              )}

              {monitorIds && monitorIds.length === 1 && (
                <p>1 monitor was successfully submitted.</p>
              )}

              {monitorIds && monitorIds.length > 1 && (
                <p>{monitorIds.length} monitors were successfully submitted.</p>
              )}

              {(siteIds.length !== 0 || monitorIds.length !== 0) && (
                <p>
                  <Link to={basepath}>View Map</Link>.
                </p>
              )}
            </Prompt>
          )}

          {submitStatus === 'failure' && (
            <Prompt className="alert alert-danger" role="alert">
              <p>Something went wrong...</p>
            </Prompt>
          )}
        </div>
      </UserPage>
    );
  }
}

export default UserUploadSitesFile;
