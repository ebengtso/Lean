# SPX500 IB Trend Scalper Analysis

- Metrics file: `/Users/erikbengtson/Lean2026/LeanCustom/LauncherBacktest/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm-optimizer-runs/run_043/execution-metrics.csv`
- Backtest file: `/Users/erikbengtson/Lean2026/LeanCustom/LauncherBacktest/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm-optimizer-runs/run_043/launcher/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm.json`
- Completed paired trades: 79
- Entry signals: 80
- Approx open/unpaired entry signals: 1
- Position/order maintenance waits: 34413
- Total paired trade PnL: 3878.80
- Win rate: 100.0%
- Realized loss trades: 0
- Median hold: 14.5 minutes
- Average hold: 134.2 minutes

## Lean Runtime Statistics
- Equity: $102,300.30
- Net Profit: $3,878.80
- Return: 2.30 %
- Probabilistic Sharpe Ratio: 99.144%
- Volume: $29,942,638.20

## Risk And Efficiency
- Exposure hours: 176.7
- PnL per exposure hour: 21.95
- Calendar span days: 11.6
- PnL per calendar day: 333.45
- Trades per calendar day: 6.79
- Exposure share of calendar time: 63.3%
- Growth quality score: 4899.3
- VIX stale at entry: 0.0%
- ES stale rows: 9.7%
- Waiting ES VWAP rows: 0.0%
- Trade-health exit signals: 0
- Trade-health tighten signals: 0
- Slow trades held >= 12 hours: 2 (2.5%)
- Slow exposure hours: 116.1
- Slow PnL per exposure hour: 0.59
- Fast <15m trades: 41
- Fast PnL per exposure hour: 565.14

## Pullback Broken Structure Veto
- Blocked signal rows: 224
- Blocked by profile: `{"charm_pin_pullback_long": 221, "pullback_long": 3}`
- Blocked net profit / worst MAE: not available for hard-blocked signals because they do not become completed trades.
- Remaining trades by profile: `{"breakout_long_1dte": 7, "charm_pin_pullback_long": 35, "pullback_long": 26, "pullback_long_no_0dte": 11}`
- Remaining PnL by profile: `{"breakout_long_1dte": 464.4999999999427, "charm_pin_pullback_long": 1200.2000000001144, "pullback_long": 1772.1000000001113, "pullback_long_no_0dte": 442.0}`

## Lean Portfolio And Trade Statistics
- Portfolio: sharpeRatio=17.2641, sortinoRatio=33.7043, alpha=0, beta=0, informationRatio=17.7598, drawdown=0.041
- Trades: sharpeRatio=1.4734, averageMAE=-206.7741, averageMFE=64.1766, largestMAE=-4387.70, largestMFE=170.0, maximumIntraTradeDrawdown=-4425.10

## Strategy Profile Performance

| Strategy | Enabled | Data State | Profile Set | Trades | PnL | Avg PnL | Win Rate | Median Hold Min | Exposure Hrs | PnL/Exposure Hr | Slow >=12h | Worst MAE | Median MFE | Median TP |
| --- | --- | --- | --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| pullback_long | true | VALID_0DTE | VALID_0DTE | 26 | 1772.10 | 68.16 | 100.0% | 13.4 | 42.4 | 41.80 | 1 | -1985.60 | 81.60 | 3.41 |
| charm_pin_pullback_long | true | VALID_0DTE | VALID_0DTE | 35 | 1200.20 | 34.29 | 100.0% | 12.0 | 118.6 | 10.12 | 1 | -4387.70 | 40.80 | 2.40 |
| breakout_long_1dte | true | VALID_1DTE_ONLY | VALID_1DTE_ONLY | 7 | 464.50 | 66.36 | 100.0% | 13.2 | 3.2 | 145.99 | 0 | -327.25 | 106.75 | 3.00 |
| pullback_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 8 | 243.10 | 30.39 | 100.0% | 30.3 | 12.2 | 19.98 | 0 | -225.25 | 26.35 | 4.00 |
| pullback_long_no_0dte | true | EXPIRED_0DTE | EXPIRED_0DTE | 3 | 198.90 | 66.30 | 100.0% | 9.2 | 0.4 | 453.76 | 0 | -65.45 | 73.95 | 3.91 |
| breakout_long | false | VALID_0DTE | VALID_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| squeeze_long | true | VALID_0DTE | VALID_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| wall_reclaim_long | false | VALID_0DTE | VALID_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| wall_breakout_retest_long | false | VALID_0DTE | VALID_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| late_day_pin_fade | false | VALID_0DTE | VALID_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| negative_gamma_momentum_long | false | VALID_0DTE | VALID_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| trend_day_pullback_long | false | VALID_0DTE | VALID_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| charm_wall_breakaway_long | true | VALID_0DTE | VALID_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| call_wall_acceptance_long | true | VALID_0DTE | VALID_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| breakout_long_no_0dte | true | MISSING_0DTE | MISSING_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| pullback_long_no_0dte | true | MISSING_0DTE | MISSING_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| squeeze_long_no_0dte | true | MISSING_0DTE | MISSING_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |

## Strategy Entry Fingerprints

| Strategy | Enabled | Data State | Profile Set | Trades | Median Setup | Median ES-VWAP | Median RSI | Median ADX | Avg Hold Min | Slow >=12h |
| --- | --- | --- | --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| pullback_long | true | VALID_0DTE | VALID_0DTE | 26 | 51.56 | 6.39 | 43.95 | 36.21 | 97.8 | 1 |
| charm_pin_pullback_long | true | VALID_0DTE | VALID_0DTE | 35 | 66.57 | 22.42 | 44.24 | 26.59 | 203.2 | 1 |
| breakout_long_1dte | true | VALID_1DTE_ONLY | VALID_1DTE_ONLY | 7 | 62.19 | 4.64 | 56.44 | 45.01 | 27.3 | 0 |
| pullback_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 8 | 55.47 | 4.93 | 45.25 | 35.19 | 91.2 | 0 |
| pullback_long_no_0dte | true | EXPIRED_0DTE | EXPIRED_0DTE | 3 | 57.10 | 1.94 | 48.74 | 51.25 | 8.8 | 0 |
| breakout_long | false | VALID_0DTE | VALID_0DTE | 0 |  |  |  |  |  | 0 |
| squeeze_long | true | VALID_0DTE | VALID_0DTE | 0 |  |  |  |  |  | 0 |
| wall_reclaim_long | false | VALID_0DTE | VALID_0DTE | 0 |  |  |  |  |  | 0 |
| wall_breakout_retest_long | false | VALID_0DTE | VALID_0DTE | 0 |  |  |  |  |  | 0 |
| late_day_pin_fade | false | VALID_0DTE | VALID_0DTE | 0 |  |  |  |  |  | 0 |
| negative_gamma_momentum_long | false | VALID_0DTE | VALID_0DTE | 0 |  |  |  |  |  | 0 |
| trend_day_pullback_long | false | VALID_0DTE | VALID_0DTE | 0 |  |  |  |  |  | 0 |
| charm_wall_breakaway_long | true | VALID_0DTE | VALID_0DTE | 0 |  |  |  |  |  | 0 |
| call_wall_acceptance_long | true | VALID_0DTE | VALID_0DTE | 0 |  |  |  |  |  | 0 |
| breakout_long_no_0dte | true | MISSING_0DTE | MISSING_0DTE | 0 |  |  |  |  |  | 0 |
| pullback_long_no_0dte | true | MISSING_0DTE | MISSING_0DTE | 0 |  |  |  |  |  | 0 |
| squeeze_long_no_0dte | true | MISSING_0DTE | MISSING_0DTE | 0 |  |  |  |  |  | 0 |

## MAE And MFE
- MAE: average -209.42, median -68.12, worst -4387.70
- MFE: average 64.18, median 51.00, best 170.00
- Average MFE / absolute MAE: 0.31

## Intratrade Path
- Trades with path stats: 79; with intratrade price samples: 79
- Went positive before max adverse: 58.2%
- MFE happened before MAE: 15.2%
- TP touched before MAE: 2.5%
- Median MFE available before MAE: 0.25 points
- Median first TP touch: 5.7 minutes
- Median first +1.5 points: 3.4 minutes
- First 15m MFE/MAE medians: 2.25 / -2.45 points

## Worst Tail Trade Autopsy
- Worst tail entry: `2026-06-25T13:30:08+00:00` -> `2026-06-29T13:45:46+00:00`.
- Strategy/profile: `charm_pin_pullback_long` / `charm_pin_pullback_long`. PnL 34.00, MAE -4387.70, MFE 37.40, hold 5775.6 minutes.
- Profile context: `charm_pin_pullback_long` produced 35 trades, PnL 1200.20, 1 slow >=12h trades, and 30.9% of total PnL.
- Entry state: setup=50.83, ES-VWAP=10.80, VWAP slope=0.0183, VWAP acceleration=0.0152, RSI=43.37, ADX=19.92, structure score=4.00, higher-low=13.25, higher-high=8.25, pullback-from-high=3.75, rolling-high distance=3.75.
- Guard state: setup allowed=`True`, entry veto allowed=`True`, veto points=3.00, slow-risk points=0.00.
- Existing warning reason: RSI slope -4.5565 <= -2.0000; ADX slope -2.3755 <= -1.0000; RSI 43.37 <= 45.00.
- Strategy selection reason: positive gamma/charm pin pullback: expectedMovePosition=-0.0071, netCharm30m=-164181, lowerFade=False, pullback=True, dynamicMaxVwapDistance=17.72.
- Intratrade path: path MFE 1.10, path MAE -128.75, MFE before MAE=`False`, TP reached=`False`.
- Surgical setup floor check: `setup_quality_score >= 50.9` would block this trade, keep 65 trades, retain 79.3% PnL, and leave worst MAE -1315.80. It would block 14 trades total.
- Candidate guards that would have blocked this tail:
  - `option_strike_map_gamma_regime_score >= 0.5`: kept 70 trades, retained 84.1% PnL, kept worst MAE -1985.60.
  - `option_strike_map_call_put_volume_imbalance >= 0.5`: kept 63 trades, retained 77.6% PnL, kept worst MAE -1985.60.
  - `rsi_slope >= -0.5`: kept 53 trades, retained 68.4% PnL, kept worst MAE -1985.60.

## Unscanned Feature Coverage
- Present trade columns: 143, scanned columns: 143, unscanned columns: 0
- No unscanned feature columns found. Good coverage for all present trade fields.

## Candidate Entry Quality Filters

| Scope | Condition | Kept | Blocked | Kept PnL | PnL Loss | Retained PnL | Slow Removed | Slow Left | Kept PnL/Exposure Hr | Kept Worst MAE | Score |
| --- | --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| all_trades | `option_strike_map_gamma_regime_score >= 0.5` | 70 | 9 | 3261.10 | 617.70 | 84.1% | 1 | 1 | 45.28 | -1985.60 | 151.6 |
| all_trades | `option_strike_map_call_put_volume_imbalance >= 0.5` | 63 | 16 | 3009.50 | 869.30 | 77.6% | 1 | 1 | 42.50 | -1985.60 | 105.3 |
| all_trades | `setup_quality_score >= 45` | 75 | 4 | 3667.80 | 211.00 | 94.6% | 1 | 1 | 24.76 | -4387.70 | 81.4 |
| all_trades | `rsi_slope >= -0.5` | 53 | 26 | 2651.20 | 1227.60 | 68.4% | 1 | 1 | 41.45 | -1985.60 | 39.3 |
| all_trades | `option_strike_map_target_3_distance >= 1` | 63 | 16 | 3247.90 | 630.90 | 83.7% | 1 | 1 | 21.32 | -4387.70 | 4.0 |
| all_trades | `setup_quality_score >= 50` | 70 | 9 | 3229.20 | 649.60 | 83.3% | 1 | 1 | 21.92 | -4387.70 | 1.7 |

## Hidden MAE Signature Candidates

| Condition | Bad Trades | Bad Blocked | Good Blocked | Kept Trades | Kept PnL | PnL Loss | Retained PnL | Kept Worst MAE | Score |
| --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| `option_strike_map_long_breakout_allowed != "False"` | 15 | 3 | 11 | 65 | 3407.90 | 470.90 | 87.9% | -4387.70 | 105410.3 |
| `option_strike_map_long_breakout_reason != "no_upside_call_volume_strike"` | 15 | 3 | 11 | 65 | 3407.90 | 470.90 | 87.9% | -4387.70 | 105410.3 |
| `es_structure_rising_vwap != "False"` | 15 | 3 | 10 | 66 | 2904.10 | 974.70 | 74.9% | -1985.60 | 76491.3 |
| `es_structure_vwap_slope <= 0.0345939` | 15 | 6 | 23 | 50 | 2759.20 | 1119.60 | 71.1% | -4387.70 | 324.0 |
| `path_half_tp_touch_minutes >= 0.6` | 15 | 5 | 18 | 56 | 3030.50 | 848.30 | 78.1% | -1315.80 | 287.0 |
| `path_first_nonzero_move_points <= -0.2` | 15 | 5 | 15 | 59 | 3002.60 | 876.20 | 77.4% | -4387.70 | 286.5 |
| `option_strike_map_next_upside_call_volume_distance <= 10.5` | 15 | 5 | 16 | 58 | 2993.10 | 885.70 | 77.2% | -4387.70 | 283.2 |
| `es_structure_score <= 4` | 15 | 5 | 21 | 53 | 2999.90 | 878.90 | 77.3% | -4387.70 | 277.0 |
| `path_half_tp_touch_minutes >= 0.266667` | 15 | 4 | 12 | 63 | 3397.40 | 481.40 | 87.6% | -1315.80 | 268.7 |
| `es_structure_vwap_slope <= 0.0364016` | 15 | 5 | 23 | 51 | 2800.00 | 1078.80 | 72.2% | -4387.70 | 238.0 |
| `path_first_nonzero_move_points >= -0.8` | 15 | 3 | 4 | 72 | 3664.60 | 214.20 | 94.5% | -4387.70 | 235.4 |
| `option_strike_map_target_3_strike <= 7550` | 15 | 5 | 23 | 51 | 2772.60 | 1106.20 | 71.5% | -4387.70 | 233.1 |

## Upside TP Extension Candidates
| all | No upside TP extension candidates found. |  |  |  |  |  |  |  |  |  |  |

## Event Counts
- position_wait: 34413
- blocked: 9866
- stale_es_vwap: 4867
- waiting_spx_quote: 415
- trade_risk_tighten_signal: 374
- order_event: 361
- entry_signal: 80

## Blocked Gate Counts
- setup_quality_allowed: 4045 (disabled=4045)
- above_vwap_confirmed: 3384 (disabled=3384)
- above_vwap: 3160 (disabled=3160)
- es_structure_allowed: 2618 (disabled=2618)
- pullback: 1774 (disabled=1774)
- momentum: 1276 (disabled=1276)
- es_vwap_slope_allowed: 886 (disabled=886)
- es_vwap_max_distance_allowed: 635 (disabled=635)
- trend_strength: 587 (disabled=587)
- indicator_slope_allowed: 501 (disabled=501)
- es_vwap_acceleration_allowed: 443 (disabled=443)

## By UTC Hour

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 15 | 10 | 683.40 | 68.34 | 100.0% | 5.6 |
| 13 | 9 | 491.30 | 54.59 | 100.0% | 5.8 |
| 14 | 9 | 295.80 | 32.87 | 100.0% | 5.1 |
| 18 | 8 | 421.30 | 52.66 | 100.0% | 14.4 |
| 7 | 7 | 428.40 | 61.20 | 100.0% | 14.5 |
| 5 | 6 | 190.40 | 31.73 | 100.0% | 62.9 |
| 1 | 5 | 395.50 | 79.10 | 100.0% | 1.6 |
| 17 | 5 | 146.20 | 29.24 | 100.0% | 42.2 |
| 19 | 4 | 211.80 | 52.95 | 100.0% | 257.7 |
| 4 | 4 | 222.70 | 55.67 | 100.0% | 21.9 |
| 0 | 2 | 129.20 | 64.60 | 100.0% | 8.6 |
| 11 | 2 | 39.10 | 19.55 | 100.0% | 80.1 |
| 22 | 2 | 103.70 | 51.85 | 100.0% | 17.0 |
| 8 | 2 | 34.00 | 17.00 | 100.0% | 40.9 |
| 10 | 1 | 17.00 | 17.00 | 100.0% | 12.2 |
| 12 | 1 | 17.00 | 17.00 | 100.0% | 47.2 |
| 2 | 1 | 35.00 | 35.00 | 100.0% | 133.4 |
| 6 | 1 | 17.00 | 17.00 | 100.0% | 21.5 |

## By RSI Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <55 | 74 | 3557.80 | 48.08 | 100.0% | 14.5 |
| 55-60 | 4 | 286.00 | 71.50 | 100.0% | 7.0 |
| >=75 | 1 | 35.00 | 35.00 | 100.0% | 133.4 |

## By ADX Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 30-40 | 19 | 1193.40 | 62.81 | 100.0% | 10.7 |
| <20 | 17 | 761.80 | 44.81 | 100.0% | 11.2 |
| 40-50 | 13 | 595.70 | 45.82 | 100.0% | 15.9 |
| 25-30 | 12 | 489.60 | 40.80 | 100.0% | 25.0 |
| >=50 | 11 | 657.10 | 59.74 | 100.0% | 11.8 |
| 20-25 | 7 | 181.20 | 25.89 | 100.0% | 47.2 |

## By VIX Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| missing | 79 | 3878.80 | 49.10 | 100.0% | 14.5 |

## By ES VWAP Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-0.25 | 77 | 3756.40 | 48.78 | 100.0% | 14.5 |
| -0.25-0 | 1 | 105.40 | 105.40 | 100.0% | 6.3 |
| 0.25-0.5 | 1 | 17.00 | 17.00 | 100.0% | 26.5 |

## By ES VWAP Acceleration Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| -0.05-0 | 36 | 1650.70 | 45.85 | 100.0% | 15.2 |
| 0-0.05 | 36 | 1917.70 | 53.27 | 100.0% | 14.2 |
| 0.1-0.25 | 2 | 119.00 | 59.50 | 100.0% | 18.3 |
| -0.1--0.05 | 1 | 17.00 | 17.00 | 100.0% | 55.4 |
| -0.25--0.1 | 1 | 40.80 | 40.80 | 100.0% | 1.9 |
| 0.05-0.1 | 1 | 35.00 | 35.00 | 100.0% | 13.2 |
| <-0.25 | 1 | 81.60 | 81.60 | 100.0% | 1.9 |
| >=0.25 | 1 | 17.00 | 17.00 | 100.0% | 26.5 |

## By ES Rolling High Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-1 | 23 | 1306.20 | 56.79 | 100.0% | 24.9 |
| 2-4 | 21 | 929.90 | 44.28 | 100.0% | 12.0 |
| 1-2 | 13 | 533.10 | 41.01 | 100.0% | 12.5 |
| 4-6 | 10 | 303.60 | 30.36 | 100.0% | 16.2 |
| 12-20 | 4 | 309.40 | 77.35 | 100.0% | 2.3 |
| 8-12 | 4 | 180.20 | 45.05 | 100.0% | 40.9 |
| 6-8 | 2 | 166.80 | 83.40 | 100.0% | 4.3 |
| >=20 | 2 | 149.60 | 74.80 | 100.0% | 11.4 |

## By ES Rolling High Minutes Since

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <1 | 22 | 1406.00 | 63.91 | 100.0% | 14.1 |
| 20-30 | 19 | 1018.80 | 53.62 | 100.0% | 14.5 |
| 10-20 | 15 | 549.10 | 36.61 | 100.0% | 12.0 |
| 5-10 | 12 | 436.90 | 36.41 | 100.0% | 14.6 |
| 1-3 | 8 | 384.70 | 48.09 | 100.0% | 12.5 |
| 3-5 | 3 | 83.30 | 27.77 | 100.0% | 34.7 |

## By RSI Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| >=3 | 42 | 2047.70 | 48.75 | 100.0% | 16.2 |
| <-3 | 15 | 625.60 | 41.71 | 100.0% | 27.0 |
| -1-0 | 9 | 320.60 | 35.62 | 100.0% | 12.0 |
| -2--1 | 3 | 336.80 | 112.27 | 100.0% | 1.9 |
| 0-1 | 3 | 204.00 | 68.00 | 100.0% | 3.9 |
| missing | 3 | 74.80 | 24.93 | 100.0% | 12.2 |
| 1-2 | 2 | 193.50 | 96.75 | 100.0% | 6.1 |
| -3--2 | 1 | 40.80 | 40.80 | 100.0% | 4.1 |
| 2-3 | 1 | 35.00 | 35.00 | 100.0% | 14.0 |

## By ADX Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| >=3 | 26 | 1310.50 | 50.40 | 100.0% | 14.5 |
| 0-1 | 11 | 515.80 | 46.89 | 100.0% | 13.2 |
| -3--2 | 10 | 537.20 | 53.72 | 100.0% | 11.1 |
| -1-0 | 8 | 462.60 | 57.83 | 100.0% | 20.4 |
| <-3 | 8 | 246.50 | 30.81 | 100.0% | 20.9 |
| 2-3 | 6 | 279.80 | 46.63 | 100.0% | 13.6 |
| 1-2 | 4 | 370.00 | 92.50 | 100.0% | 3.3 |
| -2--1 | 3 | 81.60 | 27.20 | 100.0% | 28.2 |
| missing | 3 | 74.80 | 24.93 | 100.0% | 12.2 |

## By ES Higher-Low Distance Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-8 | 26 | 1267.60 | 48.75 | 100.0% | 13.6 |
| 2-4 | 24 | 1308.80 | 54.53 | 100.0% | 11.3 |
| 1-2 | 12 | 540.80 | 45.07 | 100.0% | 13.5 |
| 0.5-1 | 7 | 278.80 | 39.83 | 100.0% | 21.5 |
| 0-0.5 | 5 | 115.60 | 23.12 | 100.0% | 20.4 |
| >=8 | 5 | 367.20 | 73.44 | 100.0% | 11.8 |

## By ES Structure Score

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4 | 34 | 2004.90 | 58.97 | 100.0% | 13.5 |
| 5 | 26 | 878.90 | 33.80 | 100.0% | 15.5 |
| 3 | 19 | 995.00 | 52.37 | 100.0% | 14.0 |

## By ES Structure Pullback From High

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-2 | 46 | 2241.50 | 48.73 | 100.0% | 15.5 |
| 2-4 | 19 | 926.50 | 48.76 | 100.0% | 12.2 |
| 4-8 | 11 | 595.20 | 54.11 | 100.0% | 14.5 |
| 8-12 | 2 | 34.00 | 17.00 | 100.0% | 40.9 |
| 12-16 | 1 | 81.60 | 81.60 | 100.0% | 1.9 |

## By ES Structure Higher-Low Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 27 | 1489.70 | 55.17 | 100.0% | 14.0 |
| 2-4 | 15 | 533.10 | 35.54 | 100.0% | 15.0 |
| 4-8 | 11 | 446.60 | 40.60 | 100.0% | 12.2 |
| 0-0.5 | 9 | 334.90 | 37.21 | 100.0% | 21.5 |
| 1-2 | 8 | 486.90 | 60.86 | 100.0% | 12.2 |
| 0.5-1 | 5 | 288.40 | 57.68 | 100.0% | 12.8 |
| >=8 | 4 | 299.20 | 74.80 | 100.0% | 9.1 |

## By ES Structure Higher-High Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 29 | 1414.90 | 48.79 | 100.0% | 14.5 |
| 2-4 | 17 | 781.70 | 45.98 | 100.0% | 14.5 |
| 1-2 | 9 | 356.70 | 39.63 | 100.0% | 33.2 |
| 4-8 | 8 | 369.60 | 46.20 | 100.0% | 12.2 |
| 0.5-1 | 6 | 383.70 | 63.95 | 100.0% | 14.6 |
| 0-0.5 | 5 | 205.00 | 41.00 | 100.0% | 15.9 |
| >=8 | 5 | 367.20 | 73.44 | 100.0% | 11.8 |

## By ES Structure VWAP Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-8 | 21 | 1118.10 | 53.24 | 100.0% | 16.4 |
| >=24 | 14 | 436.90 | 31.21 | 100.0% | 10.0 |
| 16-24 | 12 | 338.30 | 28.19 | 100.0% | 17.4 |
| 2-4 | 10 | 679.40 | 67.94 | 100.0% | 12.8 |
| 8-12 | 9 | 679.30 | 75.48 | 100.0% | 27.0 |
| 12-16 | 7 | 309.40 | 44.20 | 100.0% | 12.0 |
| 0-2 | 6 | 317.40 | 52.90 | 100.0% | 13.0 |

## By Setup Quality Score

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 50-60 | 33 | 1746.80 | 52.93 | 100.0% | 16.5 |
| 60-70 | 26 | 995.50 | 38.29 | 100.0% | 12.8 |
| 40-50 | 9 | 649.60 | 72.18 | 100.0% | 11.2 |
| 70-80 | 9 | 405.30 | 45.03 | 100.0% | 11.8 |
| 80-90 | 2 | 81.60 | 40.80 | 100.0% | 5.3 |

## By Entry-Veto Points

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 1-2 | 19 | 899.80 | 47.36 | 100.0% | 12.2 |
| 2-3 | 16 | 810.90 | 50.68 | 100.0% | 18.5 |
| 3-4 | 15 | 598.70 | 39.91 | 100.0% | 15.9 |
| 4-5 | 12 | 462.40 | 38.53 | 100.0% | 16.6 |
| 5-6 | 9 | 613.90 | 68.21 | 100.0% | 7.2 |
| <1 | 8 | 493.10 | 61.64 | 100.0% | 4.1 |

## By Slow-Risk Points

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <1 | 79 | 3878.80 | 49.10 | 100.0% | 14.5 |

## By Entry Risk Tier

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| standard | 79 | 3878.80 | 49.10 | 100.0% | 14.5 |

## By ES Reclaim Current Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-8 | 21 | 1118.10 | 53.24 | 100.0% | 16.4 |
| >=24 | 14 | 436.90 | 31.21 | 100.0% | 10.0 |
| 16-24 | 12 | 338.30 | 28.19 | 100.0% | 17.4 |
| 2-4 | 10 | 679.40 | 67.94 | 100.0% | 12.8 |
| 8-12 | 9 | 679.30 | 75.48 | 100.0% | 27.0 |
| 12-16 | 7 | 309.40 | 44.20 | 100.0% | 12.0 |
| 0-2 | 6 | 317.40 | 52.90 | 100.0% | 13.0 |

## By SPX EMA20 Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 73 | 3522.80 | 48.26 | 100.0% | 14.5 |
| 0-1 | 6 | 356.00 | 59.33 | 100.0% | 14.9 |

## By Hold-Time Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 5-15 | 24 | 1402.50 | 58.44 | 100.0% | 11.1 |
| 15-30 | 17 | 556.90 | 32.76 | 100.0% | 18.3 |
| <5 | 17 | 1246.90 | 73.35 | 100.0% | 1.9 |
| 30-60 | 8 | 260.10 | 32.51 | 100.0% | 44.7 |
| 180-720 | 6 | 241.40 | 40.23 | 100.0% | 362.4 |
| 60-180 | 5 | 103.00 | 20.60 | 100.0% | 92.6 |
| >=720 | 2 | 68.00 | 34.00 | 100.0% | 3483.8 |

## By VIX Regime

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| disabled | 79 | 3878.80 | 49.10 | 100.0% | 14.5 |

## By Option Data State

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| VALID_0DTE | 61 | 2972.30 | 48.73 | 100.0% | 12.5 |
| STALE_0DTE | 8 | 243.10 | 30.39 | 100.0% | 30.3 |
| VALID_1DTE_ONLY | 7 | 464.50 | 66.36 | 100.0% | 13.2 |
| EXPIRED_0DTE | 3 | 198.90 | 66.30 | 100.0% | 9.2 |

## By Active Profile Set

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| VALID_0DTE | 61 | 2972.30 | 48.73 | 100.0% | 12.5 |
| STALE_0DTE | 8 | 243.10 | 30.39 | 100.0% | 30.3 |
| VALID_1DTE_ONLY | 7 | 464.50 | 66.36 | 100.0% | 13.2 |
| EXPIRED_0DTE | 3 | 198.90 | 66.30 | 100.0% | 9.2 |

## Monthly Summary

| Month | Trades | PnL | Avg PnL | Median Hold Min | Exposure Hours | PnL/Exposure Hour | Slow >=12h |
| --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| 2026-06 | 42 | 2204.90 | 52.50 | 12.4 | 130.2 | 16.93 | 1 |
| 2026-07 | 37 | 1673.90 | 45.24 | 15.9 | 46.5 | 35.98 | 1 |

## TP Target Distribution

| Target | Trades | PnL | Avg PnL | Median Hold Min |
| --- | ---: | ---: | ---: | ---: |
| 2.34 | 1 | 34.00 | 34.00 | 16.9 |
| 2.40 | 35 | 1200.20 | 34.29 | 12.0 |
| 2.46 | 2 | 119.00 | 59.50 | 191.8 |
| 2.65 | 1 | 34.00 | 34.00 | 58.3 |
| 2.68 | 1 | 91.80 | 91.80 | 11.2 |
| 2.71 | 1 | 37.40 | 37.40 | 351.0 |
| 2.85 | 1 | 101.50 | 101.50 | 7.2 |
| 3.00 | 7 | 464.50 | 66.36 | 13.2 |
| 3.06 | 1 | 112.20 | 112.20 | 6.7 |
| 3.07 | 1 | 105.40 | 105.40 | 6.3 |
| 3.09 | 1 | 17.00 | 17.00 | 458.8 |
| 3.25 | 1 | 34.00 | 34.00 | 1192.0 |
| 3.27 | 1 | 112.20 | 112.20 | 270.7 |
| 3.39 | 1 | 126.00 | 126.00 | 7.2 |
| 3.41 | 1 | 34.00 | 34.00 | 12.0 |
| 3.42 | 1 | 115.60 | 115.60 | 4.6 |
| 3.43 | 1 | 34.00 | 34.00 | 18.3 |
| 3.49 | 1 | 34.00 | 34.00 | 16.4 |
| 3.51 | 2 | 78.20 | 39.10 | 28.7 |
| 3.52 | 1 | 17.00 | 17.00 | 14.5 |
| 3.60 | 10 | 647.00 | 64.70 | 13.4 |
| 3.91 | 1 | 68.00 | 68.00 | 15.0 |
| 4.00 | 6 | 261.80 | 43.63 | 26.8 |

## Slow Trade Fingerprint
- Trades held >= 12 hours: 2 (2.5%)
- Slow-trade median hold: 3483.8 minutes
- Slow-trade total PnL: 68.00
- rsi14: slow median 46.51, fast<15m median 46.05
- adx14: slow median 21.73, fast<15m median 33.45
- es_minus_vwap: slow median 8.23, fast<15m median 8.68
- price_minus_ema20: slow median -15.93, fast<15m median -57.32
- es_structure_score: slow median 3.50, fast<15m median 4.00
- es_structure_pullback_from_high: slow median 3.50, fast<15m median 1.75
- es_structure_higher_low_distance: slow median 6.12, fast<15m median 1.00
- es_structure_higher_high_distance: slow median 3.75, fast<15m median 1.25
- es_structure_vwap_distance: slow median 8.23, fast<15m median 8.68
- es_vwap_acceleration: slow median 0.01, fast<15m median 0.00
- es_rolling_high_distance: slow median 4.25, fast<15m median 2.25
- es_rolling_high_minutes_since: slow median 11.93, fast<15m median 8.28
- rsi_slope: slow median 0.05, fast<15m median 3.64
- adx_slope: slow median -3.17, fast<15m median 1.54
- setup_quality_score: slow median 47.00, fast<15m median 60.73
- setup_quality_take_profit_boost: slow median 0.00, fast<15m median 0.04
- entry_veto_points: slow median 4.00, fast<15m median 2.00
- slow_risk_points: slow median 0.00, fast<15m median 0.00
- es_reclaim_current_distance: slow median 8.23, fast<15m median 8.68
- spx_ema20_distance: slow median -0.23, fast<15m median -0.06

## Interpretation Notes
- This strategy exits with take-profit orders only, so a high win rate can hide capital being tied up for a long time.
- The best setting candidates are usually found by reducing slow-to-profit entries, not simply maximizing raw entry count.
- Focus first on buckets with low average PnL or long median hold time, then test stricter RSI/ADX/VWAP/VIX filters against those buckets.
