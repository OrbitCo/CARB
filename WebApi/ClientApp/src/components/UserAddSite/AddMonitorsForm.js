// @flow

import React from 'react';
import { Tooltip } from '@progress/kendo-react-tooltip';
import { Button } from '@progress/kendo-react-buttons';
import { Dialog, DialogActionsBar } from '@progress/kendo-react-dialogs';
// components
import {
  MonitorId,
  MonitorPurpose,
  MonitorManufacturer,
  MonitorModel,
  MonitorFirmwareVersion,
  MonitorPurchaseDate,
  MonitorLastServiceDate,
  MonitorParameters,
  ParameterMeasurementTechnique,
  ParameterMeasurementUnits,
  ParameterSamplingDuration,
  ParameterSamplingFrequency,
  ParameterDetectionRangeUnits,
  ParameterUpperDetectionLimit,
  ParameterLowerDetectionLimit,
  ParameterMethodDetectionLimit,
  ParameterUncertainty,
  ParameterPrecision,
  ParameterMeasurementResolution,
  ParameterLastCalibrationTimestamp,
  DateStart,
  MonitorCfrSiting,
  MonitorFlowRate,
  MonitorInletHeight,
  MonitorInletOrientation,
  MonitorInletDiameter,
  MonitorSystemDescription,
} from 'components/User/FormFields';
// styled components
import {
  Heading2,
  Heading3,
  Form,
  FormButton,
  Row,
  RowHeader,
  RowContent,
  RowHeading,
  CloseButton,
  SaveButton,
} from 'components/User/StyledComponents';

// --- components ---
type Props = {
  siteName: string,
  siteId: string,
  onFieldsSubmit: (any) => void,
};

type Parameter = { parameterCode: string, parameterName: string };

type State = {
  monitors: Array<{ id: string, monitorParameters: Array<Parameter> }>,
  monitorToDeleteById: string,
  validityStylesShown: boolean,
  deleteDialogShown: boolean,
  saveDialogShown: boolean,
  submitDialogShown: boolean,
  formSubmitted: boolean,
};

class AddMonitorsForm extends React.Component<Props, State> {
  state: State = {
    monitors: [{ id: Date.now(), monitorParameters: [] }],
    monitorToDeleteById: '',
    validityStylesShown: false,
    deleteDialogShown: false,
    saveDialogShown: false,
    submitDialogShown: false,
    formSubmitted: false,
  };

  monitorsFieldsets = []; // ref of each monitor fieldset

  addMonitor = () => {
    this.setState((state, props) => {
      return {
        monitors: [
          ...state.monitors,
          { id: Date.now(), monitorParameters: [] },
        ],
      };
    });
  };

  removeMonitor = () => {
    const { monitorToDeleteById } = this.state;
    this.closeDeleteDialog();
    this.setState((state, props) => {
      return {
        monitors: state.monitors.filter((m) => m.id !== monitorToDeleteById),
        monitorToDeleteById: '',
      };
    });
  };

  updateMonitorParams = (monitor, params) => {
    this.setState((state, props) => {
      // get portion of monitors array before and after monitor
      const index = state.monitors.indexOf(monitor);
      const monitorsBeforeIndex = state.monitors.slice(0, index);
      const monitorsAfterIndex = state.monitors.slice(index + 1);
      // update monitor with params
      return {
        monitors: [
          ...monitorsBeforeIndex,
          { ...monitor, monitorParameters: params },
          ...monitorsAfterIndex,
        ],
      };
    });
  };

  validateFields = (ev, status) => {
    this.setState({ validityStylesShown: true });

    if (!this.form.checkValidity()) return;
    ev.preventDefault();

    if (status === 'draft') {
      this.openSaveDialog();
      this.submitData('draft');
    }

    if (status === 'submitted') {
      this.openSubmitDialog();
    }
  };

  openDeleteDialog = (monitorId) => {
    this.setState({
      deleteDialogShown: true,
      monitorToDeleteById: monitorId,
    });
  };

  closeDeleteDialog = () => {
    this.setState({
      deleteDialogShown: false,
      monitorToDeleteById: '',
    });
  };

  openSaveDialog = () => {
    this.setState({ saveDialogShown: true });
  };

  closeSaveDialog = () => {
    this.setState({ saveDialogShown: false });
  };

  openSubmitDialog = () => {
    this.setState({ submitDialogShown: true });
  };

  closeSubmitDialog = () => {
    this.setState({ submitDialogShown: false });
  };

  submitData = (status) => {
    const fields = {
      _transactionType: 'AM[]',
      _addMonitorsFormStatus: status,
      siteId: this.props.siteId,
      siteMonitors: [],
    };

    // iterate over each monitor fieldset
    [...this.monitorsFieldsets].forEach((monitorsFieldset, monitorsIndex) => {
      if (!monitorsFieldset) return;

      // array used to differentiate monitor fields and param fields
      const allParamFields = [];

      // object to hold each form element's name and value
      const monitor = { monitorParameters: [] };

      // build up array of params fieldsets by examining each form element's data attributes
      const paramsFieldsets = [];
      [...monitorsFieldset.elements].forEach((el) => {
        if (el.dataset.monitorParams) paramsFieldsets.push(el);
      });

      // add params to monitor object
      paramsFieldsets.forEach((paramsFieldset, paramsIndex) => {
        const { monitors } = this.state;
        const p = monitors[monitorsIndex].monitorParameters[paramsIndex];
        const { parameterCode, parameterName } = p;

        // build up parameter object with each param field's name and value
        const parameter = { parameterCode, parameterName };

        [...paramsFieldset.elements].forEach((el) => {
          // ignore form elements without a name attribute
          if (!el.name) return;
          allParamFields.push(el);
          parameter[el.name] = el.value;
        });

        monitor.monitorParameters.push(parameter);
      });

      // add all non-param fields to the monitor object
      [...monitorsFieldset.elements].forEach((el) => {
        // ignore form elements without a name attribute
        if (!el.name) return;
        // ensure field isn't a param field, which were all added previously
        if (allParamFields.indexOf(el) !== -1) return;
        monitor[el.name] = el.value;
      });

      fields.siteMonitors.push(monitor);
    });

    if (status === 'submitted') {
      this.closeSubmitDialog();
      this.setState({ formSubmitted: true });
    }

    // pass fields up to parent component to be handled
    this.props.onFieldsSubmit(fields);
  };

  render() {
    const {
      monitors,
      validityStylesShown,
      formSubmitted,
      deleteDialogShown,
      saveDialogShown,
      submitDialogShown,
    } = this.state;

    return (
      <>
        <Heading2>Monitors at {this.props.siteName}</Heading2>

        <Form
          ref={(el) => (this.form = el)}
          onSubmit={(ev) => this.validateFields(ev, 'submitted')}
        >
          {monitors.map((monitor, monitorIndex) => (
            <fieldset
              key={monitor.id}
              ref={(el) => (this.monitorsFieldsets[monitorIndex] = el)}
            >
              <Row className="row">
                <RowHeader>
                  <RowHeading>Monitor {monitorIndex + 1}</RowHeading>

                  {!formSubmitted && (
                    <Tooltip anchorElement="target" position="left">
                      <CloseButton
                        primary
                        icon="close-circle"
                        title="Remove Monitor"
                        onClick={(ev) => {
                          ev.preventDefault();
                          this.openDeleteDialog(monitor.id);
                        }}
                      />
                    </Tooltip>
                  )}
                </RowHeader>

                <RowContent>
                  <div className="col-sm-12">
                    <Heading3>Monitor Specs</Heading3>
                  </div>

                  <div className="col-md-6">
                    <MonitorId
                      validityStyles={validityStylesShown}
                      required={true}
                      disabled={formSubmitted}
                    />
                  </div>

                  <div className="col-md-6">
                    <MonitorPurpose
                      validityStyles={validityStylesShown}
                      required={true}
                      disabled={formSubmitted}
                    />
                  </div>

                  <div className="col-md-4">
                    <MonitorManufacturer
                      validityStyles={validityStylesShown}
                      required={true}
                      disabled={formSubmitted}
                    />
                  </div>

                  <div className="col-md-4">
                    <MonitorModel
                      validityStyles={validityStylesShown}
                      required={true}
                      disabled={formSubmitted}
                    />
                  </div>

                  <div className="col-md-4">
                    <MonitorFirmwareVersion
                      validityStyles={validityStylesShown}
                      required={false}
                      disabled={formSubmitted}
                    />
                  </div>

                  <div className="col-md-4">
                    <MonitorPurchaseDate
                      validityStyles={validityStylesShown}
                      required={false}
                      disabled={formSubmitted}
                    />
                  </div>

                  <div className="col-md-4">
                    <MonitorLastServiceDate
                      validityStyles={validityStylesShown}
                      required={false}
                      disabled={formSubmitted}
                    />
                  </div>

                  <div className="col-md-4">
                    <DateStart
                      validityStyles={validityStylesShown}
                      required={true}
                      disabled={formSubmitted}
                    />
                  </div>

                  <div className="col-md-12">
                    <MonitorParameters
                      validityStyles={validityStylesShown}
                      required={true}
                      disabled={formSubmitted}
                      defaultValue={monitor.monitorParameters}
                      onChange={(ev) => {
                        this.updateMonitorParams(monitor, ev.target.value);
                      }}
                    />
                  </div>

                  <div className="col-md-12">
                    {monitor.monitorParameters.map((param, paramIndex) => (
                      <fieldset key={paramIndex} data-monitor-params>
                        <Row className="row">
                          <RowHeader>
                            <RowHeading>
                              {param.parameterName}
                              &nbsp;&nbsp;(Parameter Code {param.parameterCode})
                            </RowHeading>
                          </RowHeader>

                          <RowContent>
                            <div className="col-md-4">
                              <ParameterMeasurementTechnique
                                validityStyles={validityStylesShown}
                                required={true}
                                disabled={formSubmitted}
                              />
                            </div>

                            <div className="col-md-4">
                              <ParameterMeasurementUnits
                                validityStyles={validityStylesShown}
                                required={true}
                                disabled={formSubmitted}
                              />
                            </div>

                            <div className="col-md-4">
                              <ParameterSamplingDuration
                                validityStyles={validityStylesShown}
                                required={true}
                                disabled={formSubmitted}
                              />
                            </div>

                            <div className="col-md-4">
                              <ParameterSamplingFrequency
                                validityStyles={validityStylesShown}
                                required={true}
                                disabled={formSubmitted}
                              />
                            </div>

                            <div className="col-md-4">
                              <ParameterDetectionRangeUnits
                                validityStyles={validityStylesShown}
                                required={false} // TODO: make required if any of the other detection limit fields are filled (upper, lower, method)
                                disabled={formSubmitted}
                              />
                            </div>

                            <div className="col-md-4">
                              <ParameterUpperDetectionLimit
                                validityStyles={validityStylesShown}
                                required={false}
                                disabled={formSubmitted}
                              />
                            </div>

                            <div className="col-md-4">
                              <ParameterLowerDetectionLimit
                                validityStyles={validityStylesShown}
                                required={false}
                                disabled={formSubmitted}
                              />
                            </div>

                            <div className="col-md-4">
                              <ParameterMethodDetectionLimit
                                validityStyles={validityStylesShown}
                                required={false}
                                disabled={formSubmitted}
                              />
                            </div>

                            <div className="col-md-4">
                              <ParameterUncertainty
                                validityStyles={validityStylesShown}
                                required={false}
                                disabled={formSubmitted}
                              />
                            </div>

                            <div className="col-md-4">
                              <ParameterPrecision
                                validityStyles={validityStylesShown}
                                required={false}
                                disabled={formSubmitted}
                              />
                            </div>

                            <div className="col-md-4">
                              <ParameterMeasurementResolution
                                validityStyles={validityStylesShown}
                                required={false}
                                disabled={formSubmitted}
                              />
                            </div>

                            <div className="col-md-4">
                              <ParameterLastCalibrationTimestamp
                                validityStyles={validityStylesShown}
                                required={true}
                                disabled={formSubmitted}
                              />
                            </div>

                            <div className="col-md-4" />

                            <div className="col-md-4">
                              <DateStart
                                validityStyles={validityStylesShown}
                                required={true}
                                disabled={formSubmitted}
                              />
                            </div>

                            <div className="col-md-4" />
                          </RowContent>
                        </Row>
                      </fieldset>
                    ))}
                  </div>

                  <div className="col-sm-12">
                    <Heading3>Monitor Setup</Heading3>
                  </div>

                  <div className="col-md-6">
                    <MonitorCfrSiting
                      validityStyles={validityStylesShown}
                      required={true}
                      disabled={formSubmitted}
                    />
                  </div>

                  <div className="col-md-6">
                    <MonitorFlowRate
                      validityStyles={validityStylesShown}
                      required={false}
                      disabled={formSubmitted}
                    />
                  </div>

                  <div className="col-md-4">
                    <MonitorInletHeight
                      validityStyles={validityStylesShown}
                      required={false}
                      disabled={formSubmitted}
                    />
                  </div>

                  <div className="col-md-4">
                    <MonitorInletOrientation
                      validityStyles={validityStylesShown}
                      required={false}
                      disabled={formSubmitted}
                    />
                  </div>

                  <div className="col-md-4">
                    <MonitorInletDiameter
                      validityStyles={validityStylesShown}
                      required={false}
                      disabled={formSubmitted}
                    />
                  </div>

                  <div className="col-sm-12">
                    <MonitorSystemDescription
                      required={false}
                      disabled={formSubmitted}
                    />
                  </div>
                </RowContent>
              </Row>
            </fieldset>
          ))}

          {!formSubmitted && (
            <>
              <div className="row">
                <div className="col-md-12">
                  <FormButton
                    primary
                    icon="plus-circle"
                    onClick={(ev) => {
                      ev.preventDefault();
                      this.addMonitor();
                    }}
                  >
                    Add Monitor
                  </FormButton>

                  <SaveButton
                    primary
                    icon="save"
                    onClick={(ev) => this.validateFields(ev, 'draft')}
                  >
                    Save Draft
                  </SaveButton>
                </div>
              </div>

              <div className="row">
                <div className="col-md-12 text-right">
                  <FormButton
                    primary
                    icon="table-insert"
                    onClick={(ev) => this.validateFields(ev, 'submitted')}
                  >
                    Submit Monitors
                  </FormButton>
                </div>
              </div>
            </>
          )}
        </Form>

        {deleteDialogShown && (
          <Dialog
            title="Confirm Monitor Deletion"
            width={400}
            onClose={(ev) => this.closeDeleteDialog()}
          >
            <p>Are you sure you want to delete this monitor?</p>
            <DialogActionsBar>
              <Button onClick={(ev) => this.closeDeleteDialog()}>No</Button>
              <Button onClick={(ev) => this.removeMonitor()}>
                Yes, Delete Monitor
              </Button>
            </DialogActionsBar>
          </Dialog>
        )}

        {saveDialogShown && (
          <Dialog
            title="Monitor Data Saved"
            width={400}
            onClose={(ev) => this.closeSaveDialog()}
          >
            <p>A draft of your site’s monitor data has been saved.</p>
            <p>
              <strong>IMPORTANT: Your data has not been submitted.</strong>
            </p>
            <p>
              You’ll still need to click the “Submit Monitors” button to submit
              your monitor data to your site.
            </p>
            <DialogActionsBar>
              <Button primary onClick={(ev) => this.closeSaveDialog()}>
                OK
              </Button>
            </DialogActionsBar>
          </Dialog>
        )}

        {submitDialogShown && (
          <Dialog
            title="Confirm Monitors and Sensors"
            width={400}
            onClose={(ev) => this.closeSubmitDialog()}
          >
            <p>
              You’re about to add monitors and sensors to your site. After
              added, you’ll be able to edit your site’s monitors and sensors
              from your Dashboard, but now is a good time to double check that
              the data you entered is accurate.
            </p>
            <p>
              Click <strong>Cancel</strong> to double check the fields you’ve
              entered.
            </p>
            <p>
              Click <strong>Submit Monitors</strong> to proceed with adding
              monitors and sensors to your site.
            </p>
            <DialogActionsBar>
              <Button onClick={(ev) => this.closeSubmitDialog()}>Cancel</Button>
              <Button primary onClick={(ev) => this.submitData('submitted')}>
                Submit Monitors
              </Button>
            </DialogActionsBar>
          </Dialog>
        )}
      </>
    );
  }
}

export default AddMonitorsForm;
